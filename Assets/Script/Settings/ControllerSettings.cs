using UnityEngine;

namespace Settings
{
    /// <summary>
    /// All the settings regarding the controller.
    /// </summary>
    [CreateAssetMenu(fileName = "NewControllerSettings", menuName = "Settings/ControllerSettings")]
    public class ControllerSettings : ScriptableObject
    {
        public float anglePerPoint = 1 / 360;
        public float horizontalCameraSensitivity = 1;
        public float verticalCameraSensitivity = 1;
    }
}

