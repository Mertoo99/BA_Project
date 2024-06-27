using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Stelle sicher, dass der VideoPlayer im Inspector zugewiesen ist.

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoFinished;  // Event, das aufgerufen wird, wenn das Video endet
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  // Überprüfen, ob die Escape-Taste gedrückt wurde
        {
            LoadGame();  // Spiel laden
        }
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        LoadGame();  // Spiel laden, wenn das Video endet
    }

    void LoadGame()
    {
        SceneManager.LoadScene("Game");  // Name der Spielszene
    }
}


