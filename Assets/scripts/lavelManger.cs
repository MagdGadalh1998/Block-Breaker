using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lavelManger : MonoBehaviour
{
    
    public void StartGame(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
        briks.breakableCount = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        briks.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel+1);
    }
    public void BrickDestroyed()
    {
        if (briks.breakableCount<=0)
        {
            LoadNextLevel();
        }
    }

    
}
