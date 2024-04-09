using System;

namespace CustomException
{
    public class SettingsManagerException: Exception
    {
        public SettingsManagerException() 
        {

        }
        public SettingsManagerException(string message) : base(message)
        {
            
        }
    }
}
