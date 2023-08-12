using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            bool vidaRecuperada = GameManger.Instance.recuperarVida();

            if (vidaRecuperada)
            {
                Destroy(this.gameObject);

            }
            
        }
    }
}
