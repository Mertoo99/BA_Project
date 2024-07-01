using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ExitCutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;

    void Start()
    {
        if (videoPlayer != null && audioSource != null)
        {
            Debug.Log("Both VideoPlayer and AudioSource are assigned.");

            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.SetTargetAudioSource(0, audioSource);

            videoPlayer.loopPointReached += OnVideoFinished;
            videoPlayer.prepareCompleted += OnVideoPrepared;

            Debug.Log("Preparing the video...");
            videoPlayer.Prepare();
        }
        else
        {
            Debug.LogError("Either VideoPlayer or AudioSource is not assigned.");
        }
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video is prepared and now playing.");
        audioSource.Play();
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("ExitCutscene finished, loading ThanksScene.");
        LoadThanksScene();
    }

    void LoadThanksScene()
    {
        Debug.Log("Loading ThanksScene.");
        SceneManager.LoadScene("ThanksScene");
    }
}

