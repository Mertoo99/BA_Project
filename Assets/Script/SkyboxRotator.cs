using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    void Update()
    {
        // Rotiere die Skybox um die Y-Achse
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}

