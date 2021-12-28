using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BorderCollision : MonoBehaviour
{
    public GameObject popTimer;


    public static TextMeshProUGUI popTimerText;

    private int flag = 0;
    private int minusTime = -5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("crash"))
        {
            TImerScript.t -= 5;
            Debug.Log("border");
            popTimer.SetActive(true);
            flag=1;
            //popTimerText.text = "-5";
            //popTimerText.fontSize = 30;
            //Destroy(other.gameObject);
        }

    }



    private IEnumerator ActivationRoutine()
    {

        if (flag == 1)
        {
            yield return new WaitForSeconds(.5f);

            //Game object will turn off
            popTimer.SetActive(false);
            flag = 0;
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ActivationRoutine());
    }
}
