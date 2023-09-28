using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hunterJumpscare : MonoBehaviour
{
   
    public Animator hunterAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;

    void OnTriggerEnter(Collider other) //когда включается триггер анимации прыжка, игрок отключается, включается анимация нападения Охотника и включается сцена смерти
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            hunterAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }

}
