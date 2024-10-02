using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //opens the hub
    public void playButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    //quits the game
    public void exitButton()
    {
        Application.Quit();
    }
}
