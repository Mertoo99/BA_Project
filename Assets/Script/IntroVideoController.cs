using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Stelle sicher, dass der VideoPlayer im Inspector zugewiesen ist.
    public AudioSource audioSource;  // Füge eine AudioSource hinzu und stelle sicher, dass sie im Inspector zugewiesen ist.

    void Start()
    {
        if (videoPlayer != null && audioSource != null)
        {
            // Stelle sicher, dass der VideoPlayer den AudioSource als Ausgabemodus verwendet
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.SetTargetAudioSource(0, audioSource);

            // Registriere das Event, das aufgerufen wird, wenn das Video endet
            videoPlayer.loopPointReached += OnVideoFinished;

            // Bereite das Video vor und spiele es ab, wenn die Vorbereitung abgeschlossen ist
            videoPlayer.prepareCompleted += OnVideoPrepared;
            videoPlayer.Prepare();
        }
        else
        {
            Debug.LogError("VideoPlayer oder AudioSource ist nicht zugewiesen.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  // Überprüfen, ob die Escape-Taste gedrückt wurde
        {
            LoadLogbookScene();  // Wechsel zur LogbookScene
        }
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        // Starte Audio und Video gleichzeitig
        audioSource.Play();
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        LoadLogbookScene();  // Wechsel zur LogbookScene, wenn das Video endet
    }

    void LoadLogbookScene()
    {
        SceneManager.LoadScene("LogbookScene");  // Name der Logbook Szene
    }
}

