using UnityEngine;
using RayFramework;


namespace UnityRayFramework.Runtime
{
    public sealed class BaseComponent:RayFrameworkComponent
    {
        [SerializeField]
        private bool m_RunInBackground = true;

        [SerializeField]
        private bool m_NeverSleep = true;

        public bool RunInBackground
        {
            get => m_RunInBackground;
            set => Application.runInBackground = m_RunInBackground = value;
        }

        public bool NeverSleep
        {
            get => m_NeverSleep;
            set
            {
                m_NeverSleep = value;
                Screen.sleepTimeout = value ? SleepTimeout.NeverSleep : SleepTimeout.SystemSetting;
            }
        }

        protected override void Awake()
        {
            base.Awake();

            Application.runInBackground = m_RunInBackground;
            Screen.sleepTimeout = m_NeverSleep ? SleepTimeout.NeverSleep : SleepTimeout.SystemSetting;
        }

        private void Update()
        {
            GameFrameworkEntry.Update(Time.deltaTime, Time.realtimeSinceStartup);
        }

        private void OnDestroy()
        {
            GameFrameworkEntry.Shutdown();
        }

        internal void Shutdown()
        {
            Destroy(gameObject);
        }
    }
}
