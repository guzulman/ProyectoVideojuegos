using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaVida : MonoBehaviour
{

    int vidas = 3;
    public PlayerHealth playerHealth;
    public void perderVidas()
    {
        vidas -= 1;
        playerHealth.desactivarVida(vidas);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            GameManger.Instance.perderVida();



        }
    }
}