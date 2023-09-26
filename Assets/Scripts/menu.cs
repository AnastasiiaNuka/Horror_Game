using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public GameObject loadingscreen;
    public string sceneName;

    public void playGame() //при нажатии на плей, покажет экран загрузки и первый левел начнется
    {
        loadingscreen.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void quitGame()
    {
        Debug.Log("This will quit the game, only works in actual build, not in Unity editor.");
        Application.Quit();
    }
}

    
  


