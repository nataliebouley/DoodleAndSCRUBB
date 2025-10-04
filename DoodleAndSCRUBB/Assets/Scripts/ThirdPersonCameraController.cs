using Unity.Hierarchy;
using Unity.Cinemachine;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    [SerializeField] private float zoomSpeed = 2.0f;
    [SerializeField] private float zoomLerpSpeed = 10.0f;
    [SerializeField] private float minDistance = 3.0f;
    [SerializeField] private float maxDistance = 15.0f;

    private PlayerControls controls;

    private CinemachineCamera cam;
    private CinemachineOrbitalFollow orbital;
    private Vector2 scrollDelta;

    private float targetZoom;
    private float currentZoom;

    private

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controls = new PlayerControls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
