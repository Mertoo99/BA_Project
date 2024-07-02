using UnityEngine;
using UnityEngine.SceneManagement;

public class LogbookSceneController : MonoBehaviour
{
    private bool canProceed = false; // Eine Flag, um den Fortschritt zu kontrollieren

    void Start()
    {
        // Setzt die Flag auf true nach einer kurzen Verzögerung
        Invoke("EnableProceed", 5.0f); // 5 Sekunden Verzögerung
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
        Debug.Log("Drücke ESC, um zur Game Szene zu wechseln.");
    }

    void LoadNextScene()
    {
        Debug.Log("Lade Game Szene...");
        SceneManager.LoadScene("Game");
    }
}

