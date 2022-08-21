using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ButStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButEnd()
    {
        Application.Quit();
    }
}
