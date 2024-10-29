using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene"); // Replace "MainScene" with the name of your game scene
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting"); // This only shows in the editor; it won't appear in the build
    }
}
