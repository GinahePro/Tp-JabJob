using UnityEngine;

namespace GameConst
{ 
    /// <summary>
    /// All the settings regarding the PlayerBody behaviour.
    /// </summary>
    [CreateAssetMenu(fileName = "NewPlayerBodyFixedData", menuName = "GameParam/PlayerBodyFixedParameter")]
    public class PlayerBodyConst :ScriptableObject
    {

        [SerializeField] float groundDrag;
        [SerializeField] float groundMovementPower;
        [SerializeField] float groundMaxSpeed;
        [SerializeField] float airDrag;
        [SerializeField] float airMovementPower;
        [SerializeField] float airMaxSpeed;

        public float GroundDrag { get { return groundDrag; } private set { } }
        public float GroundMovementPower { get {  return groundMovementPower; } private set { } }
        public float GroundMaxSpeed { get {  return groundMaxSpeed; } private set { } }
        public float AirDrag { get {return airDrag; } private set { } }
        public float AirMovementPower { get { return airMovementPower; } private set { } }
        public float AirMaxSpeed { get { return airMaxSpeed; } private set { } }
    }
}
