
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hunterJumpscare : MonoBehaviour
{
    public Animator hunterAnim;
    public GameObject player;
    public AudioSource hunterSource;
    public float jumpscareTime;
    public string sceneName;

    void OnTriggerEnter(Collider other) //����� ���������� ������� �������� ������, ����� �����������, ���������� �������� ��������� �������� � ���������� ����� ������
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            hunterSource.enabled = false;
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