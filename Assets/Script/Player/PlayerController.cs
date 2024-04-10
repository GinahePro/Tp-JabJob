using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Settings;
using DesignPattern.Singleton;
using System.Linq;
using Unity.Plastic.Newtonsoft.Json.Bson;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;

namespace Player
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerController : Singleton<PlayerController>
    {
        [SerializeField]
        ControllerSettings controlerSettings;

        string currentControlScheme;

        public Vector2 WantedMovement = new();
        public Vector2 WantedLookMovement = new();

        public UnityEvent Jump;
        private void Start()
        {

        }

        void Update()
        {
            
        }

        void OnControlsChanged(PlayerInput playerInput)
        {
            currentControlScheme = playerInput.currentControlScheme;
        }

        void OnMovement(InputValue value)
        {
            WantedMovement = value.Get<Vector2>();
        }
        void OnCamera(InputValue value)
        {
            WantedLookMovement = value.Get<Vector2>();
            if (WantedLookMovement.magnitude < 0.1f)
            {
                WantedLookMovement = Vector2.zero;
            }
            WantedLookMovement.x *= controlerSettings.horizontalCameraSensitivity;
            WantedLookMovement.y *= controlerSettings.verticalCameraSensitivity;
        }
        void OnMainInteraction(InputValue value)
        {

        }
        void OnJump(InputValue value)
        {
            Jump.Invoke();
        }

    }
}