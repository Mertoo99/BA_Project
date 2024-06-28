using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoFinished;
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
