using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PatrolPlataform : MonoBehaviour
{

    [SerializeField]
    Transform[] points;

    [SerializeField]
    float speed;

    [SerializeField]
    bool isFacingRight;

    Rigidbody2D _rb;

    int _index;

    Transform _target;



    private void Start()
    {
        SetNextTarget(0);
    }

    private void Update()
    {
        if (transform.position == _target.position)
        {
            _index++;

            if (_index >= points.Length)
            {
                _index = 0;
            }
            SetNextTarget(_index);
        }

        transform.position =
            Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }
    private void SetNextTarget(int index)
    {
        _index = index;
        _target = points[_index];

        if (_target.position.x > transform.position.x && !isFacingRight)
        {
            if (!isFacingRight)
            {
                isFacingRight = !isFacingRight;
                transform.Rotate(0.0F, 180.0F, 0.0F);
            }
        }
        else if (_target.position.x < transform.position.x && isFacingRight)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0.0F, 180.0F, 0.0F);
        }
    }
}
