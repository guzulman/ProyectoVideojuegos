using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;

public class GameManger : MonoBehaviour
{



public static GameManger Instance { get; private set; }


    private int vidas = 3;
    public PlayerHealth playerHealth;
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;

        }
        else{
            Debug.Log("Mas de un Game Manager en escena!");

        }
    }

    public void perderVida()
    {
        vidas -= 1;
        if(vidas == 0)
        {
            SceneManager.LoadScene(2);
        }
        playerHealth.desactivarVida(vidas);


    }
    public void perderVidaPorCaida()
    {
        vidas -= 3;
        if (vidas == 0 || vidas <0)
        {
            SceneManager.LoadScene(2);
        }
        //playerHealth.desactivarVida(vidas);


    }

    public bool recuperarVida()
    {
        if(vidas == 3)
        {
            return false;
        }
        playerHealth.activarVida(vidas);
        vidas+= 1;

        return true;
    }
}
