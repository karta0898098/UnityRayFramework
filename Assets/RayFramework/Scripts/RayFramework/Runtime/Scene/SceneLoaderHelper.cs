using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using RayFramework;

namespace UnityRayFramework.Runtime
{
    public class SceneLoaderHelper : MonoBehaviour, ISceneLoaderHelper
    {
        public void LoadScene(string sceneAssetName, Action success, Action<float> progess, Action failed)
        {
            var task = new SceneLoaderTask(success, progess, failed);
            StartCoroutine(task.LoadScene(sceneAssetName));
        }
    }
}
