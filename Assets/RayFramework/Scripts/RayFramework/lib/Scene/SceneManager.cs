using System;
using RayFramework.Resource;

namespace RayFramework
{
    internal class SceneManager : RayCoreModule, ISceneManager
    {

        public event Action OnLoadSuccessEvent;
        public event Action<float> OnLoadProgessEvent;
        public event Action OnLoadFailEvent;

        public void SetResourceManager(IResource resource)
        {

        }

        public void LoadScene(string sceneAssetName)
        {

        }

        public void LoadScene(string sceneAssetName, object userData)
        {

        }

        private void InternalLoadScene(string sceneAssetName, object userData)
        {

        }

        public void UnLoadScene(string sceneAssetName)
        {

        }

        public void UnLoadScene(string sceneAssetName, object userData)
        {

        }

        private void InternalUnLoadScene(string sceneAssetName, object userData)
        {

        }

        private void UpdateLoadSuccessEvent()
        {
            OnLoadSuccessEvent?.Invoke();
        }

        private void UpdateProgessEvent(float progess)
        {
            OnLoadProgessEvent?.Invoke(progess);
        }

        private void UpdateFailEvent()
        {
            OnLoadFailEvent?.Invoke();
        }

        internal override void Update(float timeTick, float realTimeTick)
        {

        }

        internal override void Shoudown()
        {

        }
    }
}
