using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TImerScript : MonoBehaviour
{

    public static TImerScript _instance;
    public TextMeshProUGUI timerText;

    private float startTime;
    public float t=300;
    public float total;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        timer();


    }

    public void timer()
    {
        _instance = this;
        t -= Time.deltaTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = min + ":" + sec;
        // temp = 60 - temp;
        if (t < 2)
        {
            SceneManager.LoadScene(4);
        }

    }
}
