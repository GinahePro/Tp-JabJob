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
            //movementForce += _context.controller.WantedMovement.y * _context.playerTransform.forward;
            //movementForce += _context.controller.WantedMovement.x * _context.playerTransform.right;


            //_context.rb.AddForce(movementForce, ForceMode.Force);
            _context.playerTransform.Rotate(0,_context.controller.WantedLookMovement.x, 0);

            _context.verticalRotationAngle -= _context.controller.WantedLookMovement.y;

            if (_context.verticalRotationAngle > 70) _context.verticalRotationAngle = 70 ;
            if (_context.verticalRotationAngle < - 70) _context.verticalRotationAngle = -70;
            _context.cameraVerticalRotationPoint.localRotation = Quaternion.Euler(_context.verticalRotationAngle, 0 , 0) ;
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

