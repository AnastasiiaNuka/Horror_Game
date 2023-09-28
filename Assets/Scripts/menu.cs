
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject loadingscreen;
    public string sceneName, sceneName2;
    public Button continueButton;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("level") == 0) // для нулевого уровня кнопка продолжения отсутствует
        {
            continueButton.interactable = false;
        }
    }
    public void playGame()//при нажатии на плей, покажет экран загрузки и первый левел начнется
    {
        loadingscreen.SetActive(true);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
    public void continueGame() //загрузится последний сыгранный уровень 
    {
        loadingscreen.SetActive(true);
        if (PlayerPrefs.GetInt("level", 2) == 2)
        {
            SceneManager.LoadScene(sceneName2);
        }
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void quitGame()
    {
        Debug.Log("This will quit the game, only works in actual build, not in Unity editor.");
        Application.Quit();
    }
  
}





