using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonHunter : MonoBehaviour
{
    public GameObject hunter, block1, block2, block3;
    public Collider collision;
    public bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hunter.SetActive(true);
            if (blocks == true)
            {
                block1.SetActive(true);
                block2.SetActive(true);
                block3.SetActive(false);
            }
            collision.enabled = false;
        }
    }
}
