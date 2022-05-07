using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale= 1f;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale= 0f;
    }

    public void LoadMainMenu()
    {
        Time.timeScale= 1f;
        SceneManager.LoadScene(0);
    }
}
