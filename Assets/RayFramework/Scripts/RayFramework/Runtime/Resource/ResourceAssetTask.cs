using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityRayFramework.Runtime
{
    public class ResourceAssetTask
    {
        public IEnumerator AsyncLoadAsset<T>(string assetPath, Action<T> OnSuccess) 
        {
            var loader = Resources.LoadAsync(assetPath);
            while (!loader.isDone)
            {
                yield return null;
            }

            if (loader.asset != null)
            {
                var value = (T)Convert.ChangeType(loader.asset, typeof(T));
                OnSuccess?.Invoke(value);
            }
        }
    }
}
