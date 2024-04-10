using UnityEngine;
using DesignPattern.BaseStateMachine;
using GameConst;
using UnityEngine.Events;

namespace Player
{
    public class PlayerContext : StateContext
    {
        public PlayerController controller;
        public PlayerBodyConst playerBodyConst;
        public Transform playerTransform;
        public Transform cameraVerticalRotationPoint;
        public Rigidbody rb;
        public UnityEvent onGround;

        public float verticalRotationAngle;

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
            controller = transform.gameObject.GetComponent<PlayerController>();
            this.cameraVerticalRotationPoint = cameraVerticalRotationPoint;
            this.rb = rb;

        }
    }
}
