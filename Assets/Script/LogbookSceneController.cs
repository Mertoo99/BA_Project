using UnityEngine;
using UnityEngine.SceneManagement;

public class LogbookSceneController : MonoBehaviour
{
    private bool canProceed = false; // Eine Flag, um den Fortschritt zu kontrollieren

    void Start()
    {
        // Setzt die Flag auf true nach einer kurzen Verz�gerung
        Invoke("EnableProceed", 5.0f); // 5 Sekunden Verz�gerung
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canProceed)
        {
            LoadNextScene();
        }
    }

    void EnableProceed()
    {
        canProceed = true; // Erlaubt das Wechseln der Szene
        Debug.Log("Dr�cke ESC, um zur Game Szene zu wechseln.");
    }

    void LoadNextScene()
    {
        Debug.Log("Lade Game Szene...");
        SceneManager.LoadScene("Game");
    }
}

