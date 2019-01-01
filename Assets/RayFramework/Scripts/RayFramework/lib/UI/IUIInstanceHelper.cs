using System;
using System.Collections.Generic;


namespace RayFramework.UI
{
    public interface IUIInstanceHelper
    {

        void Show<T>(string uiName, Action<T> OnSuccess = null);

        void Close(string uiName);

        void ClearCache();

        void  ResouceLoadUI<T>(string uiName, Action<T> OnSuccess);
    }
}
