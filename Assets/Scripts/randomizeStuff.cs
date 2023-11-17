using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeStuff : MonoBehaviour
{
    public GameObject switch1, switch2, switch3, switch4;
    int randNum;

    void Start()
    {
        randNum = Random.Range(0, 3);
        if (randNum == 0)
        {
            switch1.SetActive(true);
        }
        if (randNum == 1)
        {
            switch2.SetActive(true);
        }
        if (randNum == 2)
        {
            switch3.SetActive(true);
        }
        if (randNum == 3)
        {
            switch4.SetActive(true);
        }
    }
}