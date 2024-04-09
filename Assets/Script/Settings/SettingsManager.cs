using UnityEngine;
using CustomException;

namespace Settings
{
    /// <summary>
    /// Singleton class to make accessible all the settings easly. MUST be in each scene.
    /// </summary>
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance;
        private static SettingsManager instance;
        public  ControllerSettings ControllerSettings;
        public PlayerBodySettings PlayerSettings;

        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                throw (new SettingsManagerException("Multiple Settings Manager Detected"));
            }
        }

        public static void testc(ControllerSettings aaa)
        {

        }
        
    }
}
