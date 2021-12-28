using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collide : MonoBehaviour
{
    public static collide _collide;
    public TextMeshProUGUI scoreText;
    int totalCollide = 0;
   // public TextMeshProUGUI highscoreText;

    public static int countObstacle = 0;
    public AudioSource happySound;
    public AudioSource sadSound;
    public GameObject plusePoint;
    public GameObject minusPoint;
    public GameObject popUpminusTimer;
    public GameObject popUpPlusTimer;
    private int flag = 0;
    private int negativeCheck = 0;
    public TextMeshProUGUI remainingText;

    private int remainingKills = 30;




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

            TImerScript.t += 10;

            plusePoint.SetActive(true);

            popUpPlusTimer.SetActive(true);




            flag = 1;

            totalCollide += 1;
            Debug.Log(totalCollide);
            
            scoreText.text = countObstacle.ToString("0");

            remainingKills-=1;
            remainingText.text = remainingKills.ToString("0");



        }

        else if (other.CompareTag("good"))
        {
            Destroy(other.gameObject);
            
            happySound.Play();
            countObstacle -= 50;
            scoreText.text = countObstacle.ToString("0");

            negativeCheck = 1;

            TImerScript.t -= 20;
            popUpminusTimer.SetActive(true);

            minusPoint.SetActive(true);


            Debug.Log("-50");


        }

        if (PlayerPrefs.GetInt("HighScore")< countObstacle)
        {
            PlayerPrefs.SetInt("HighScore", countObstacle);
        }
        PlayerPrefs.SetInt("Score", countObstacle);


    }



    private void Start()
    {
        
    }
    private IEnumerator ActivationRoutine()
    {

        //yield return new WaitForSeconds(14);

        //Turn My game object that is set to false(off) to True(on).

        if (flag == 1)
        {
            yield return new WaitForSeconds(.5f);

            //Game object will turn off
            plusePoint.SetActive(false);
            popUpPlusTimer.SetActive(false);

            flag = 0;
        }

        if (negativeCheck == 1)
        {
            yield return new WaitForSeconds(.5f);

            //Game object will turn off
            minusPoint.SetActive(false);
            negativeCheck=0;
            popUpminusTimer.SetActive(false);
        }

        //plusePoint.SetActive(true);

        //Turn the Game Oject back off after 1 sec.
        


    }
    void Update()
    {
        StartCoroutine(ActivationRoutine());
        //Debug.Log("Update time :" + Time.deltaTime);
        if (InsBad.count == totalCollide)
        {
            SceneManager.LoadScene(4);
        }
    }
}