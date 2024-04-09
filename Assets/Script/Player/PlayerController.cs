using UnityEngine;
using UnityEngine.InputSystem;
using Settings;
using UnityEngine.Events;

namespace Player
{
    public class PlayerController
    {
        private static PlayerController instance;
        public static PlayerController Instance
        {
            get
            {
                if (instance == null)
                {
                    new PlayerController(SettingsManager.Instance.ControllerSettings);
                }
                return instance;
            }

        }

        ControllerSettings controlerSettings;
        PlayerInput playerInput = null;

        public Vector2 WantedMovement = new();
        public Quaternion HorizontalCameraRotation
        {
            get
            {
                return Quaternion.Euler(0, horizontalCameraRotationAngle, 0);
            }
        }
        float horizontalCameraRotationAngle;
        public Quaternion VerticalCameraRotation
        {
            get
            {
                return Quaternion.Euler(verticalCameraRotationAngle, 0, 0);
            }
        }
        float verticalCameraRotationAngle;

        public UnityEvent Jump;

        public PlayerController(ControllerSettings controlerSettings)
        {
            instance = this;
            this.controlerSettings = controlerSettings;
            playerInput = new PlayerInput();
            playerInput.BaseMap.Enable();

            playerInput.BaseMap.Movement.started += SetWantedMovement;
            playerInput.BaseMap.Movement.performed += SetWantedMovement;
            playerInput.BaseMap.Movement.canceled += SetWantedMovement;

            playerInput.BaseMap.CameraHorizontal.performed += SetHorizontalCameraRotation;
            playerInput.BaseMap.CameraVertical.performed += SetVerticalCameraRotation;

            playerInput.BaseMap.Jump.started += InvokeJump;
        }

        void SetWantedMovement(InputAction.CallbackContext context)
        {
            WantedMovement = context.ReadValue<Vector2>();
        }
        void SetVerticalCameraRotation(InputAction.CallbackContext context)
        {
            verticalCameraRotationAngle -= context.ReadValue<float>() * controlerSettings.verticalCameraSensitivity;
            verticalCameraRotationAngle = Mathf.Max(verticalCameraRotationAngle, -70);
            verticalCameraRotationAngle = Mathf.Min(verticalCameraRotationAngle, 70);
        }
        void SetHorizontalCameraRotation(InputAction.CallbackContext context)
        {
            horizontalCameraRotationAngle += context.ReadValue<float>() * controlerSettings.horizontalCameraSensitivity;
            if (horizontalCameraRotationAngle > 360) horizontalCameraRotationAngle -= 360;
            if (horizontalCameraRotationAngle < 0) horizontalCameraRotationAngle += 360;
        }

        void InvokeJump(InputAction.CallbackContext context)
        {
            Jump.Invoke();
        }

    }
}