using UnityEngine;
using CustomException;

namespace GameConst
{
    /// <summary>
    /// Singleton class to make accessible all the settings easly. Each scene MUST have a UNIQUE SettingsManager.
    /// </summary>
    public class SettingsManager : MonoBehaviour
    {
        private static SettingsManager instance;
        public static SettingsManager Instance
        {
            get
            {
                if (instance == null) throw (new SettingsManagerException("No Settings Manager Detected"));
                return instance;  
            }
        }

        public void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                throw (new SettingsManagerException("Multiple Settings Manager Detected"));
            }
        }
    }
}
