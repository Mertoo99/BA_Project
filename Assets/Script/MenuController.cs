using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadIntro()
    {
        Debug.Log("Lade Intro-Video-Szene.");
        SceneManager.LoadScene("IntroScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


