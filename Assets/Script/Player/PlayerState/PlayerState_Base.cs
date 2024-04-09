using UnityEngine;
using DesignPattern.BaseStateMachine;

namespace Player
{
    public class PlayerState_Base : State<PlayerContext>
    {
        public PlayerState_Base(PlayerContext context) : base(context)
        {
        }

        public override void CustomUpdate()
        {
            Vector3 movementForce = Vector3.zero;
            // Debug.Log(_context.rb.velocity.magnitude);
            movementForce += _context.controller.WantedMovement.y * _context.playerTransform.forward;
            movementForce += _context.controller.WantedMovement.x * _context.playerTransform.right;


            //_context.rb.AddForce(movementForce, ForceMode.Force);
            _context.playerTransform.rotation = _context.controller.HorizontalCameraRotation;
            _context.cameraVerticalRotationPoint.localRotation = _context.controller.VerticalCameraRotation;
        }

        public override void OnEnter()
        {

        }

        public override void OnLeave()
        {

        }
        public static bool ScaleBToGetMagAPlusB(Vector3 A, Vector3 B, float mag, out float alpha)
        {
            alpha = 0;

            //Impossible : magnitude positive
            if (mag < 0)
                return false;

            //Impossible de scaler B qui est nul
            if (mag > 0 && B.sqrMagnitude == 0)
                return false;

            float a = B.sqrMagnitude;
            float b = 2 * Vector3.Dot(A, B);
            float c = A.sqrMagnitude - (mag * mag);

            float delta = (b * b) - 4 * a * c;

            //impossible
            if (delta < 0)
                return false;

            float racDelta = delta > 0 ? Mathf.Sqrt(delta) : delta;
            alpha = (-b + racDelta) / (2 * a);

            return true;
        }
    }
}

