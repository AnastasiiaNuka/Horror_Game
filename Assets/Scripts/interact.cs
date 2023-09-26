using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    public bool interactable, toggle; //смотрит ли игрок на объект и взаимодействовал ли
    public GameObject inttext, dialogue;//текст дл€ взаимодействи€ и во врем€
    public string dialogueString;//строка дл€ текста 
    public TMPro.TextMeshProUGUI dialogueText;// сам текст
    public float dialogueTime;//врем€ отображени€ текста

    void OnTriggerStay(Collider other)// если игрок смотрит на объект, то отобразитс€ текст и интерактив включитс€
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                inttext.SetActive(true);
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)// если отвернулс€
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E)) //при нажатии на ≈ по€вл€етс€ текст и будет исчезать в нужное врем€
            {
                dialogueText.text = dialogueString;
                dialogue.SetActive(true);
                inttext.SetActive(false);
                StartCoroutine(disableDialogue());
                toggle = true;
                interactable = false;
            }
        }
    }
    IEnumerator disableDialogue() //текст выключитс€ по истечению времени
    {
        yield return new WaitForSeconds(dialogueTime);
        dialogue.SetActive(false);
    }
}