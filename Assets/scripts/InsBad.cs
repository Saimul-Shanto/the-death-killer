using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsBad : MonoBehaviour
{
    public Transform badPrefab;
    int count1 = 0;
    int count2=0;
    public static int count;
    void Start()
    {
        for (int i = -1; i < 3; i++)
        {
            float j = Random.Range(0.0f, 1.2f); ;
            Instantiate(badPrefab, new Vector3(i * 3.7f, -0.008f, (-12.68f + j)), Quaternion.identity);

            Instantiate(badPrefab, new Vector3(i * 4.5f, -0.008f, (-1.3f + j)), Quaternion.identity);

            Instantiate(badPrefab, new Vector3(i * 4.5f, -0.008f, (10.2f + j)), Quaternion.identity);
            count1 += 3;
        }
        for (int i = -3; i < 3; i++)
        {
            float j = Random.Range(0.0f, 1.2f); ;

            Instantiate(badPrefab, new Vector3(10.4f + j, 0.049f, i * 3.5f), Quaternion.identity);

            Instantiate(badPrefab, new Vector3(-.7f + j, 0.049f, i * 3.5f), Quaternion.identity);

            Instantiate(badPrefab, new Vector3(-6.13f + j, 0.049f, i * 3.5f), Quaternion.identity);

            count2 += 3;
        }
        count=count1 + count2;
        Debug.Log(count);
        
    }
}
