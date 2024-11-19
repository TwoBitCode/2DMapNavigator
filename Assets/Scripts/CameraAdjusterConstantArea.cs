using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraAdjusterConstantArea : MonoBehaviour
{
    private Camera cam;

    // Desired total visible scene area (e.g., 16 * 9 for the main game view)
    public float desiredSceneArea = 16 * 9;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // Calculate the current aspect ratio
        float currentAspect = (float)Screen.width / Screen.height;

        // Adjust the orthographic size to maintain a constant visible area
        cam.orthographicSize = Mathf.Sqrt(desiredSceneArea / currentAspect) / 2;
    }
}
