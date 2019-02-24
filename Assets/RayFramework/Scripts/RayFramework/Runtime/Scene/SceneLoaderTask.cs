using System;
using System.Collections;
using UnityEngine.SceneManagement;

namespace UnityRayFramework.Runtime
{
    public class SceneLoaderTask
    {
        readonly Action OnSuccess;
        readonly Action<float> OnProgess;
        readonly Action OnFailed;

        public SceneLoaderTask(Action success, Action<float> progess, Action failed)
        {
            OnSuccess = success;
            OnProgess = progess;
            OnFailed = failed;
        }

        public IEnumerator LoadScene(string sceneAssetName)
        {
            var task = SceneManager.LoadSceneAsync(sceneAssetName);

            if (task == null)
            {
                OnFailed?.Invoke();
            }

            while (!task.isDone)
            {
                OnProgess?.Invoke(task.progress);
                yield return null;
            }

            OnSuccess?.Invoke();
        }
    }
}
