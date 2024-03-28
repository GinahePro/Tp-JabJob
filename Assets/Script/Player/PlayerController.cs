
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    [SerializeField] PlayerSettings settings;
    PlayerInput playerInput = null;


    public Vector2 WantedMovement = new();
    public Quaternion HorizontalCameraRotation
    {
        get
        {
            return Quaternion.Euler(0, horizontalCameraRotationAngle, 0);
        }
    }
    public Quaternion VerticalCameraRotation
    {
        get
        {
            return Quaternion.Euler(verticalCameraRotationAngle, 0, 0);
        }
    }

    float verticalCameraRotationAngle;
    float horizontalCameraRotationAngle;

    void OnEnable()
    {
        instance = this;
        playerInput = new PlayerInput();
        playerInput.BaseMap.Enable();

        playerInput.BaseMap.Movement.started += SetWantedMovement;
        playerInput.BaseMap.Movement.performed += SetWantedMovement;
        playerInput.BaseMap.Movement.canceled += SetWantedMovement;

    }

    void SetWantedMovement(InputAction.CallbackContext context)
    {
        WantedMovement = context.ReadValue<Vector2>();
    }

    void SetVerticalCameraRotation(InputAction.CallbackContext context)
    {
        verticalCameraRotationAngle -= context.ReadValue<float>() * settings.verticalCameraSensitivity;
        verticalCameraRotationAngle = Mathf.Max(verticalCameraRotationAngle, -70);
        verticalCameraRotationAngle = Mathf.Min(verticalCameraRotationAngle, 70);
    }
    void SetHorizontalCameraRotation(InputAction.CallbackContext context)
    {
        horizontalCameraRotationAngle += context.ReadValue<float>() * settings.horizontalCameraSensitivity;
        if (horizontalCameraRotationAngle > 360) horizontalCameraRotationAngle -= 360;
        if (horizontalCameraRotationAngle < 0) horizontalCameraRotationAngle += 360;
    }



}
