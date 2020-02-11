using UnityEngine;
using NaughtyAttributes;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float sensitivity = 100f;
    [SerializeField] private Transform playerBody;
    [SerializeField] private new Camera camera;
    [SerializeField, MinMaxSlider(-90f, 90f)] private Vector2 maxUpAndDownAngle = new Vector2(-90f, 90f);

    private float rotationX = 0f;

    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
            sensitivity = 1f;
    }

    private void Update()
    {
        float cameraX = CustomInput.CameraX * sensitivity * Time.deltaTime;
        float cameraY = CustomInput.CameraY * sensitivity * Time.deltaTime;

        rotationX -= cameraY;

        //rotationX = Mathf.Clamp(rotationX, maxUpAndDownAngle.x, maxUpAndDownAngle.y);
        camera.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        playerBody.Rotate(Vector3.up * cameraX);
    }
}
