using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MiniMapCameraAdjuster : MonoBehaviour
{
    private Camera cam;

    // Desired total visible scene area for the MiniMap
    public float desiredSceneArea = 144f; // Adjust this value based on your MiniMap setup

    void Start()
    {
        cam = GetComponent<Camera>();
        // Fix the orthographic size for the MiniMap Camera
        cam.orthographicSize = Mathf.Sqrt(desiredSceneArea) / 2;
    }

    void Update()
    {
        // Ensure the orthographic size remains fixed for the MiniMap
        cam.orthographicSize = Mathf.Sqrt(desiredSceneArea) / 2;
    }
}
