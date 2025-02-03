using UnityEngine;

public class MainMenuManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        // Load the scene with the name "Game"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void QuitGame()
    {

        Application.Quit();
    }
}
