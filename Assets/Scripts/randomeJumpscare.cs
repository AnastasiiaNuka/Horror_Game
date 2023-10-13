using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomeJumpscare : MonoBehaviour
{
    public GameObject img1, img2;
    public float randNum, waitTime;
    public bool looping; //возникнут неожиданно или нет

    void Start()
    {
        looping = true;
        StartCoroutine(randoScares());
    }
    IEnumerator randoScares()
    {
        while (looping == true)
        {
            yield return new WaitForSeconds(waitTime);
            randNum = Random.Range(0, 3);
            if (randNum == 0)
            {
                img1.SetActive(true);
            }
            if (randNum == 1)
            {
                img2.SetActive(true);
            }
            if (randNum == 2)
            {

            }
        }
    }
}
