using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// function to load the begin scene
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// function to quit the game
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
