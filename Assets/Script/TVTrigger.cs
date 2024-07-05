using UnityEngine;
using UnityEngine.Video;

public class TVTriggerSimple : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private AudioSource audioSource;
    private bool videoEnded = false;  // Zustandsvariable, um zu überprüfen, ob das Video bereits zu Ende gespielt wurde

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        audioSource = GetComponent<AudioSource>();

        if (videoPlayer == null)
        {
            Debug.LogError("Kein VideoPlayer an diesem GameObject gefunden.");
            return;
        }

        if (audioSource == null)
        {
            Debug.LogError("Keine AudioSource an diesem GameObject gefunden.");
            return;
        }

        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
        videoPlayer.isLooping = false;  // Stellt sicher, dass das Video nicht im Loop abgespielt wird

        videoPlayer.loopPointReached += OnVideoEnded;

        videoPlayer.Pause();
        audioSource.Pause();
        Debug.Log("VideoPlayer und AudioSource sind bereit und pausiert.");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter aufgerufen mit: " + other.name);
        if (other.name == "Player" && !videoPlayer.isPlaying && !videoEnded)
        {
            Debug.Log("Player hat den Trigger betreten und das Video wird gestartet.");
            videoPlayer.Play();
            audioSource.Play();
        }
    }

    private void OnVideoEnded(VideoPlayer vp)
    {
        Debug.Log("Video ist zu Ende.");
        audioSource.Stop(); // Stoppt die Audioquelle, wenn das Video endet
        videoEnded = true;  // Setze den Zustand, dass das Video beendet wurde
    }
}
