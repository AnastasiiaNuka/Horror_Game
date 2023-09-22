using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{

    public GameObject inttext, light;
    public bool toggle = true, interactable;
    public Renderer lightBulb;
    public Material offlight, onlight;
    public AudioSource lightSwitchSound;
    public Animator switchAnim;

    void OnTriggerStay(Collider other) //если камера направлена на выключатель, текст включится, интерактивное логическое значение-тру
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other) //если отводит взгляд, то текст исчезнет
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true) //если интерактивное значение тру, то игрок может нажать Е чтобы включить свет
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                //lightSwitchSound.Play();
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }
        if (toggle == false)
        {
            light.SetActive(false);
            lightBulb.material = offlight;
        }
        if (toggle == true)
        {
            light.SetActive(true);
            lightBulb.material = onlight;
        }
    }
}
