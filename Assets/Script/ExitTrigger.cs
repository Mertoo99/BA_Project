using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    private bool playerInside = false;

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed, loading exit cutscene.");
            LoadExitCutscene();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>()) // Überprüfe, ob das GameObject einen CharacterController hat
        {
            playerInside = true;
            Debug.Log("Player entered the trigger area.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CharacterController>()) // Überprüfe, ob das GameObject einen CharacterController hat
        {
            playerInside = false;
            Debug.Log("Player left the trigger area.");
        }
    }

    void LoadExitCutscene()
    {
        SceneManager.LoadScene("ExitCutscene"); // Name der Cutscene-Szene
    }
}

