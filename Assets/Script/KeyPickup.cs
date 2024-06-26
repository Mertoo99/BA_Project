using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    // Optional: Namen des Spielers festlegen
    public string playerName = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // �berpr�fe, ob das kollidierende Objekt der Spieler ist
        if (other.gameObject.name == playerName)
        {
            PickUp();
        }
    }

    void PickUp()
    {
        // Deaktiviere das GameObject, um es "verschwinden" zu lassen
        gameObject.SetActive(false);

        // Optional: F�ge Logik hinzu, um den Schl�ssel dem Inventar des Spielers hinzuzuf�gen
        Debug.Log("Schl�ssel aufgenommen!");
    }
}
