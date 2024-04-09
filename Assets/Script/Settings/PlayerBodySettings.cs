using UnityEngine;

namespace Settings
{ 
    /// <summary>
    /// All the settings regarding the PlayerBody behaviour.
    /// </summary>
    [CreateAssetMenu(fileName ="NewPlayerSettings",menuName ="Settings/PlayerSettings")]
    public class PlayerBodySettings :ScriptableObject
    { 
        public float groundDrag;
        public float groundMovementPower;
        public float groundMaxSpeed;
        public float airDrag;
        public float airMovementPower;
        public float airMaxSpeed;
    }
}
