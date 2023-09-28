using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupKey : MonoBehaviour
{
    public GameObject inttext, key, spookystuff; //текст взаимодействия, ключ на столе, в руке,
    public AudioSource pickup; //звук поднятия
    public bool interactable, scaryEvent; // смотрит ли игрок на ключ и может ли поднять

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other) // если смотрит на ключ, что включается интекст, а для интерактивности значение тру
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true) // если тру, то нажимаем Е и ключ в руках
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inttext.SetActive(false);
                interactable = false;
                pickup.Play();
                if(scaryEvent == true)
                {
                    spookystuff.SetActive(true); 
                }
                key.SetActive(false);
               
            }
        }
    }
}
