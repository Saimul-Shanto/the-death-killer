using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class collide : MonoBehaviour
{
    public static collide _collide;
    public TextMeshProUGUI scoreText;
    int totalCollide = 0;
   // public TextMeshProUGUI highscoreText;

    public static int countObstacle = 0;
    public AudioSource happySound;
    public AudioSource sadSound;


    void Awake()
    {
        _collide = this;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bad"))
        {
            Destroy(other.gameObject);

            sadSound.Play();
            countObstacle += 100;

            totalCollide += 1;
            Debug.Log(totalCollide);
            
            scoreText.text = countObstacle.ToString("0");

        }

        else if (other.CompareTag("good"))
        {
            Destroy(other.gameObject);
            
            happySound.Play();
            countObstacle -= 50;
            scoreText.text = countObstacle.ToString("0");

            
        }
        if (PlayerPrefs.GetInt("HighScore")< countObstacle)
        {
            PlayerPrefs.SetInt("HighScore", countObstacle);
        }
        PlayerPrefs.SetInt("Score", countObstacle);


    }
    void Update()
    {
        //Debug.Log("Update time :" + Time.deltaTime);
        if (InsBad.count == totalCollide)
        {
            SceneManager.LoadScene(4);
        }
    }
}