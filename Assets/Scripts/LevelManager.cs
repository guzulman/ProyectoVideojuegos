using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{    
    /// <summary>
    /// Navigate to first scene
    /// </summary>
    public void FirstScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Navigates to next scene from current one.
    /// </summary>
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //
}

