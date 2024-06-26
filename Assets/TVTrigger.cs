using UnityEngine;
using UnityEngine.Video;

public class TVTriggerSimple : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private AudioSource audioSource;

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

        videoPlayer.Pause();
        audioSource.Pause();
        Debug.Log("VideoPlayer und AudioSource sind bereit und pausiert.");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter aufgerufen mit: " + other.name);
        if (other.name == "Player" && !videoPlayer.isPlaying)
        {
            Debug.Log("Player hat den Trigger betreten.");
            videoPlayer.Play();
            audioSource.Play();
        }
    }

    // Entferne die OnTriggerExit Methode, da wir nichts tun wollen, wenn der Spieler den Trigger verlässt.
}
