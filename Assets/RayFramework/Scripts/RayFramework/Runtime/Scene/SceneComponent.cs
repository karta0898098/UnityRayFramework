using System;
using RayFramework;
using RayFramework.Resource;

namespace UnityRayFramework.Runtime
{
    public class SceneComponent : RayFrameworkComponent
    {
        ISceneManager m_SceneManager = null;
        IResource m_Resource = null;

        public event Action OnLoadSuccessEvent;

        public event Action<float> OnLoadProgessEvent;

        public event Action OnLoadFailEvent;

        public void Start()
        {
            m_SceneManager = RayFramework.RayFrameworkEntry.GetModule<ISceneManager>();
            m_Resource = RayFramework.RayFrameworkEntry.GetModule<IResource>();
            m_SceneManager.SetResourceManager(m_Resource);
            m_SceneManager.OnLoadSuccessEvent += OnLoadSuccessEvent;
            m_SceneManager.OnLoadProgessEvent += OnLoadProgessEvent;
            m_SceneManager.OnLoadFailEvent += OnLoadFailEvent;
        }

        public void OnDestroy()
        {
            m_SceneManager.OnLoadSuccessEvent -= OnLoadSuccessEvent;
            m_SceneManager.OnLoadProgessEvent -= OnLoadProgessEvent;
            m_SceneManager.OnLoadFailEvent -= OnLoadFailEvent;
        }

        public void LoadScene(string sceneAssetName)
        {
            m_SceneManager.LoadScene(sceneAssetName);
        }

        public void UnLoadScene(string sceneAssetName)
        {
            m_SceneManager.UnLoadScene(sceneAssetName);
        }
    }
}
