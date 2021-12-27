using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credit()
    {
        SceneManager.LoadScene(1);
    }
    public void HowtoPlay()
    {
        SceneManager.LoadScene(3);
    }
}
