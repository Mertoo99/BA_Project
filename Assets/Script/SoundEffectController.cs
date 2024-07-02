using UnityEngine;

public class SoundEffectController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Überprüft, ob die Leertaste gedrückt wurde
        {
            audioSource.Play(); // Spielt den Sound ab
        }
    }
}

