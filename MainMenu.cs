using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Pressing any button with this function applied to it will cause the "Game" scene to load (basically starting the game)
        SceneManager.LoadSceneAsync("Game");
    }

    public void QuitGame()
    {
        // Pressing any button with this function applied to it will cause the enter application to close and return you to your desktop (basically quitting the game)
        Application.Quit();
    }
}
