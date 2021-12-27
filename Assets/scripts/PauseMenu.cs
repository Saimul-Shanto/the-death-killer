using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool Ispaused = false;
    public GameObject PauseMenuUi;
    //public bool muted = false;
   // public TextMeshProUGUI soundText;




    void Awake()
    {

        //sound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Ispaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        Ispaused = false;

    }
    void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        Ispaused = true;
    }

    public void Quite()
    {
        Application.Quit();
    }
    /*
    public void sound()
    {
        if (muted == false)
        {
            soundText.text = "Sound ON";
            muted = true;
            AudioListener.pause = true;

        }
        else
        {
            soundText.text = "Sound OFF";
            muted = false;
            AudioListener.pause = false;

        }
    }*/

    
    public void QuitetoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
}
