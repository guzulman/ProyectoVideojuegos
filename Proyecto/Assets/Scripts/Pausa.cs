using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{

    [SerializeField]
    private GameObject botonPausa;

    [SerializeField]
    private GameObject menuPausa;
   public void Pausar()
    {
        Time.timeScale = 0.0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void reanudar()
    {
        Time.timeScale = 1.0f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);

    }
}
