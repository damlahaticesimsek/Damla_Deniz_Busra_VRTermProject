using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public void Startt()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Screen 1");
    }
    public void Level01()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level001");
    }
    public void Level02()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level002");
    }
    public void Level03()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level003");
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Screen 1");
    }
}