using UnityEngine;
using BaseStateMachine;
using Settings;
using UnityEngine.Events;

namespace Player
{
    public class PlayerContext : StateContext
    {
        public PlayerController controller;
        public PlayerBodySettings playerBodysettings;
        public Transform playerTransform;
        public Transform cameraVerticalRotationPoint;
        public Rigidbody rb;
        public UnityEvent onGround;

        public bool tinActivated;
        public bool pewterActivated;

        public float pewterRessource;
        public float tinRessource;

        public PlayerContext
            (
            Transform transform,
            Transform cameraVerticalRotationPoint,
            Rigidbody rb
            )
        {
            playerTransform = transform;
            this.cameraVerticalRotationPoint = cameraVerticalRotationPoint;
            this.rb = rb;
            controller = PlayerController.Instance;
        }
    }
}
