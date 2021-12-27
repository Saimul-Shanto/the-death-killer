using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        scoreText.text = collide.countObstacle.ToString();


    }



}
