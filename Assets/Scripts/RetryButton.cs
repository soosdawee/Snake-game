using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    public void LoadHelp()
    {
        SceneManager.LoadScene("HelpScene");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
