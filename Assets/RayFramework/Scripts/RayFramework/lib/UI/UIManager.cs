using System;
using System.Collections.Generic;
using RayFramework.Resource;

namespace RayFramework.UI
{
    internal sealed class UIManager : RayCoreModule, IUIManager
    {

        private IUIInstanceHelper m_InstanceHelper;

        public void SetHelper(IUIInstanceHelper helper)
        {
            m_InstanceHelper = helper;
        }
        public void ClearCache()
        {
            m_InstanceHelper.ClearCache();
        }

        public void Close(string uiName)
        {
            m_InstanceHelper.Close(uiName);
        }

        public void ResouceLoadUI<T>(string uiName, Action<T> OnSuccess) 
        {
            m_InstanceHelper.ResouceLoadUI(uiName, OnSuccess);
        }

        public void Show<T>(string uiName, Action<T> OnSuccess = null)
        {
            m_InstanceHelper.Show(uiName, OnSuccess);
        }

        internal override void Shoudown()
        {

        }

        internal override void Update(float timeTick, float realTimeTick)
        {

        }
    }
}
