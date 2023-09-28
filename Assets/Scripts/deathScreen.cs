using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreen : MonoBehaviour
{
    public string SceneName;
    public float waitTime; // время возвращение на главное меню

    void Start()
    {
        StartCoroutine(loadToMenu()); //сопрограмма вернет игрока в главное меню
    }
    IEnumerator loadToMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }
}