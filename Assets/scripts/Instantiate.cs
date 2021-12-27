using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject obstacle;
    public float xPos;
    public float zPos;
    public int obstacleCount;


    void Start()
    {
        StartCoroutine(Create());
    }
   

    IEnumerator Create()
    {
        while (obstacleCount < 3)
        {
            xPos = Random.Range(-3.5f, 9.5f);
            zPos = Random.Range(-12.5f, -11.5f);
            Instantiate(obstacle, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);

            xPos = Random.Range(-3.5f, 9.5f);
            zPos = Random.Range(-1.1f, 0.0f);
            Instantiate(obstacle, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);

            xPos = Random.Range(-3.5f, 9.5f);
            zPos = Random.Range(10.5f, 11.50f);
            Instantiate(obstacle, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);

            xPos = Random.Range(10.5f, 11.7f);
            zPos = Random.Range(-12f, 11.0f);
            Instantiate(obstacle, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);

            xPos = Random.Range(10.5f, 11.7f);
            zPos = Random.Range(-12f, 11.0f);
            Instantiate(obstacle, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(.1f);
            obstacleCount += 1;
        }
    }
}
