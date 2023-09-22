using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupFlashlight : MonoBehaviour
{
    public GameObject inttext, flashlight_table, flashlight_hand; //текст взаимодействия, фонарик на столе, в руке,
    public AudioSource pickup; //звук поднятия
    public bool interactable; // смотрит ли игрок на фонарь и может ли поднять

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other) // если смотрит на фонарь, что включается интекст, а для интерактивности значение тру
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true) // если тру, то нажимаем Е и фонарик в руках
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inttext.SetActive(false);
                interactable = false;
                //pickup.Play();
                flashlight_hand.SetActive(true);
                flashlight_table.SetActive(false);
            }
        }
    }
}