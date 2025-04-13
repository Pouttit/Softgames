using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    float deltaTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Smooth FPS calculation
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;

        // Update text
        fpsText.text = $"FPS: {Mathf.Ceil(fps)}";

        // Change color based on FPS
        if (fps >= 50)
        {
            fpsText.color = Color.green;
        }
        else if (fps >= 30)
        {
            fpsText.color = Color.yellow;
        }
        else
        {
            fpsText.color = Color.red;
        }
    }
}
