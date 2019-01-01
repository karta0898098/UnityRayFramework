using System;
using System.Collections.Generic;
using RayFramework.UI;
using UnityEngine;

namespace UnityRayFramework.Runtime
{
    public class UIInstanceHelper :MonoBehaviour, IUIInstanceHelper
    {
        public void ClearCache()
        {

        }

        public void Close(string uiName)
        {

        }

        public void ResouceLoadUI<T>(string uiName, Action<T> OnSuccess)
        {
            Debug.Log(uiName);
        }

        public void Show<T>(string uiName, Action<T> OnSuccess = null)
        {
            Debug.Log(uiName);
        }
    }
}
