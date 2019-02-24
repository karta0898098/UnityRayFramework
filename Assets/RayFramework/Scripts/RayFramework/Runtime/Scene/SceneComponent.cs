using System;
using RayFramework;
using UnityEngine.SceneManagement;

namespace UnityRayFramework.Runtime
{
    public class SceneComponent : RayFrameworkComponent
    {
        ISceneManager m_SceneManager = null;
        ISceneLoaderHelper m_SceneHelper = null;

        public event Action OnLoadSuccessEvent;

        public event Action<float> OnLoadProgessEvent;

        public event Action OnLoadFailEvent;

        public event Action OnUnLoadSuccessEvent;

        public event Action<float> OnUnLoadProgessEvent;

        public event Action OnUnLoadFailEvent;

        public void Start()
        {
            m_SceneManager = RayFramework.RayFrameworkEntry.GetModule<ISceneManager>();
            m_SceneHelper = GetComponent<ISceneLoaderHelper>();
            m_SceneManager.SetResourceManager(m_SceneHelper);
            m_SceneManager.OnLoadSuccessEvent += OnLoadSuccessEvent;
            m_SceneManager.OnLoadProgessEvent += OnLoadProgessEvent;
            m_SceneManager.OnLoadFailEvent += OnLoadFailEvent;
            m_SceneManager.OnUnLoadSuccessEvent += OnUnLoadSuccessEvent;
            m_SceneManager.OnUnLoadProgessEvent += OnUnLoadProgessEvent;
            m_SceneManager.OnUnLoadFailEvent += OnUnLoadFailEvent;
        }

        public void OnDestroy()
        {
            m_SceneManager.OnLoadSuccessEvent -= OnLoadSuccessEvent;
            m_SceneManager.OnLoadProgessEvent -= OnLoadProgessEvent;
            m_SceneManager.OnLoadFailEvent -= OnLoadFailEvent;
            m_SceneManager.OnUnLoadSuccessEvent -= OnUnLoadSuccessEvent;
            m_SceneManager.OnUnLoadProgessEvent -= OnUnLoadProgessEvent;
            m_SceneManager.OnUnLoadFailEvent -= OnUnLoadFailEvent;
        }

        public void LoadScene(string sceneAssetName)
        {
            m_SceneManager.LoadScene(sceneAssetName);
        }

        public void LoadAddScene(string sceneAssetName)
        {
            m_SceneManager.LoadScene(sceneAssetName, LoadSceneMode.Additive);
        }

        public void UnLoadScene(string sceneAssetName)
        {
            m_SceneManager.UnLoadScene(sceneAssetName);
        }
    }
}
