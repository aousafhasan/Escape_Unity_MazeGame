using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MapSelect");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MapOneDay()
    {
        SceneManager.LoadScene("MapOneDay");
    }
    public void MapOneNight()
    {
        SceneManager.LoadScene("MapOneNight");
    }
    public void MapTwoDay()
    {
        SceneManager.LoadScene("MapTwoDay");
    }
    public void MapTwoNight()
    {
        SceneManager.LoadScene("MapTwoNight");
    }
}
