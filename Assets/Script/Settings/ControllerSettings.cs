using UnityEngine;

namespace Settings
{
    /// <summary>
    /// All the settings regarding the controller.
    /// </summary>
    [CreateAssetMenu(fileName = "NewControllerSettings", menuName = "Settings/ControllerSettings")]
    public class ControllerSettings : ScriptableObject
    {
        public float horizontalCameraSensitivity;
        public float verticalCameraSensitivity;
    }
}

