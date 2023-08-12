using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    [SerializeField]
    Transform[] spawnObjects;

    [SerializeField]
    Transform[] spawningPoints;

    [SerializeField]
    float timeBetweenSpawn = 3.0F;

    float _currentTime;
    float _speedMultiplayer;
    void Start()
    {
        _currentTime = timeBetweenSpawn;

        
    }
    void Update()
    {

        _currentTime += Time.deltaTime;

        _speedMultiplayer += Time.deltaTime * 0.3F;

        if (_currentTime >= timeBetweenSpawn)
        {
            _currentTime = 0.0F;

            int spawningIndex = Random.Range(0, spawnObjects.Length);
            Transform prefab = spawnObjects[spawningIndex];

            SpawingObjectController controller = prefab.GetComponent<SpawingObjectController>();
            int[] spawingPoints = controller.GetSpawningPoints();

            spawningIndex = spawingPoints[Random.Range(0, spawingPoints.Length)];

            foreach (Transform point in this.spawningPoints)
            {
                if (point.gameObject.name.Equals("Point" + spawningIndex.ToString()))
                {
                   Instantiate(prefab, point.position, Quaternion.identity);
                    break;
                }
            }


        }
    }

    public float GetSpeedMultiplayer()
    {
        return _speedMultiplayer;
    }
}
