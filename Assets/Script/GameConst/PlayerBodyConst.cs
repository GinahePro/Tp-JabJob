using UnityEngine;

namespace GameConst
{ 
    /// <summary>
    /// All the const regarding the PlayerBody behaviour.
    /// </summary>
    [CreateAssetMenu(fileName = "NewPlayerBodyConst", menuName = "GameConst/PlayerBodyConst")]
    public class PlayerBodyConst :ScriptableObject
    {
        [Header("On Ground")]
        [SerializeField][Range(0f, 5f )] float groundDrag;
        [SerializeField] float groundMovementPower;
        [SerializeField] float groundMaxSpeed;
        public float GroundDrag { get { return groundDrag; } private set { } }
        public float GroundMovementPower { get { return groundMovementPower; } private set { } }
        public float GroundMaxSpeed { get { return groundMaxSpeed; } private set { } }

        [Header("In Air")]
        [SerializeField][Range(0f, 5)] float airDrag;
        [SerializeField] float airMovementPower;
        [SerializeField] float airMaxSpeed;
        public float AirDrag { get { return airDrag; } private set { } }
        public float AirMovementPower { get { return airMovementPower; } private set { } }
        public float AirMaxSpeed { get { return airMaxSpeed; } private set { } }

        [Header("Clamp Angle for vertical player view")]
        [SerializeField][Range(0f, 90)] float clampAngleLookingUp;
        [SerializeField][Range(0f, -90)] float clampAngleLookingDown;
        public float ClampAngleLookingUp { get {  return clampAngleLookingUp; } private set { } }
        public float ClampAngleLookingDown { get {  return clampAngleLookingDown; } private set { } }


    }
}
