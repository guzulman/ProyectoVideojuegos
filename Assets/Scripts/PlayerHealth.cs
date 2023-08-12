using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject[] vidas;

    public void desactivarVida(int index)
    {
        vidas[index].SetActive(false);

    }

    public void activarVida(int index)
    {
        vidas[index].SetActive(true);

    }
}
