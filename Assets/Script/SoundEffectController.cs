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
        if (Input.GetKeyDown(KeyCode.Space)) // �berpr�ft, ob die Leertaste gedr�ckt wurde
        {
            audioSource.Play(); // Spielt den Sound ab
        }
    }
}

