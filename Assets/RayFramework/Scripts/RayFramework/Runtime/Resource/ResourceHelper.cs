using System;
using RayFramework;
using RayFramework.Resource;
using UnityEngine;

namespace UnityRayFramework.Runtime
{
    public sealed class ResourceHelper: MonoBehaviour, IResourceHelper
    {
        public void LoadAsset<T>(string asset, Action<T> OnSuccess)
        {
            var task = new ResourceAssetTask();
            StartCoroutine(task.AsyncLoadAsset(asset, OnSuccess));
        }
    }
}
