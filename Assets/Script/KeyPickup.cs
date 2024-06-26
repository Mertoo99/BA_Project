using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    // Optional: Namen des Spielers festlegen
    public string playerName = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Überprüfe, ob das kollidierende Objekt der Spieler ist
        if (other.gameObject.name == playerName)
        {
            PickUp();
        }
    }

    void PickUp()
    {
        // Deaktiviere das GameObject, um es "verschwinden" zu lassen
        gameObject.SetActive(false);

        // Optional: Füge Logik hinzu, um den Schlüssel dem Inventar des Spielers hinzuzufügen
        Debug.Log("Schlüssel aufgenommen!");
    }
}
