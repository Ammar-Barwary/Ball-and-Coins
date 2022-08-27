using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public string resetScene;
    public static bool isPause = false;
    public GameObject menuPause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    void Pause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(resetScene);
        Time.timeScale = 1f;
        isPause = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        isPause = false;
    }
}
