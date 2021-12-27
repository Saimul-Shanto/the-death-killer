using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ins : MonoBehaviour
{
    
    public Transform prefab;
    void Start()
    {
        for (int i = -1; i < 3; i++)
        {
            float j = Random.Range(0.0f,1.2f); ;
            Instantiate(prefab, new Vector3(i * 4.5f, 0.049f, (-12.68f+j)), Quaternion.identity);

            Instantiate(prefab, new Vector3(i * 3.7f, 0.049f, (-1.3f+j)), Quaternion.identity);

            Instantiate(prefab, new Vector3(i * 3.5f, 0.049f, (10.2f + j)), Quaternion.identity);


            Instantiate(prefab, new Vector3(i * 3.5f, 0.049f, (10.2f + j)), Quaternion.identity);
        }

        for (int i = -3; i < 3; i++)
        {
            float j = Random.Range(0.0f, 1.2f); ;

            Instantiate(prefab, new Vector3(10.4f+j, 0.049f, i * 3.5f), Quaternion.identity);

            Instantiate(prefab, new Vector3(-.7f+j, 0.049f, i * 3.5f), Quaternion.identity);

            Instantiate(prefab, new Vector3(-6.13f+j, 0.049f, i * 3.5f), Quaternion.identity);


        }
    }
}
