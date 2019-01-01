using System;
using RayFramework;
using RayFramework.UI;

namespace UnityRayFramework.Runtime
{
    public sealed class UIComponent: RayFrameworkComponent
    {
        private IUIManager m_UIManager;
        private IUIInstanceHelper m_UIInstanceHelper;

        protected override void Awake()
        {
            base.Awake();

            var UIInstanceHelper = GetComponent<IUIInstanceHelper>();
            m_UIManager = GameFrameworkEntry.GetModule<IUIManager>();
            m_UIManager.SetHelper(UIInstanceHelper);

        }

        public void Show<T>(string uiName, Action<T> OnSuccess = null)
        {
            m_UIManager.Show(uiName, OnSuccess);
        }

        public void Close(string uiName)
        {
            m_UIManager.Close(uiName);
        }

        private void ResouceLoadUI<T>(string uiName, Action<T> OnSuccess)
        {
            m_UIManager.ResouceLoadUI(uiName, OnSuccess);
        }

        public void ClearCache()
        {

        }
    }
}
