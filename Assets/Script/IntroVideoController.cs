using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += EndReached;  // Event, das aufgerufen wird, wenn das Video endet
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  // �berpr�fen, ob die Escape-Taste gedr�ckt wurde
        {
            LoadGame();  // Spiel laden
        }
    }

    void EndReached(VideoPlayer vp)
    {
        LoadGame();  // Spiel laden, wenn das Video endet
    }

    void LoadGame()
    {
        SceneManager.LoadScene("Game");  // Name der Spielszene
    }
}

