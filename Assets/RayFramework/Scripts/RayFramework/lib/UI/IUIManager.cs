using System;
using System.Collections.Generic;


namespace RayFramework.UI
{
    public interface IUIManager
    {
        void SetHelper(IUIInstanceHelper helper);

        void Show<T>(string uiName, Action<T> OnSuccess = null);

        void Close(string uiName);

        void ResouceLoadUI<T>(string uiName, Action<T> OnSuccess);

        void ClearCache();
    }
}
