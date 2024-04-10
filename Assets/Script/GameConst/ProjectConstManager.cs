using DesignPattern.Singleton;

namespace GameConst
{
    /// <summary>
    /// Singleton class to make accessible all the const easly. Each scene MUST have a UNIQUE SettingsManager.
    /// </summary>
    public class ProjectConstManager : Singleton<ProjectConstManager>
    {

        public PlayerBodyConst PlayerBodyConst;
        public PlayerControllerConst PlayerControllerConst;

        protected override void Awake()
        {
            base.Awake();
        }

    }
}
