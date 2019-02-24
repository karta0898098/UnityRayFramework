using System;
using RayFramework.Resource;

namespace RayFramework
{
    public interface ISceneManager
    {
        event Action OnLoadSuccessEvent;

        event Action<float> OnLoadProgessEvent;

        event Action OnLoadFailEvent;

        void SetResourceManager(IResource resource);

        void LoadScene(string sceneAssetName);

        void LoadScene(string sceneAssetName, object userData);

        void UnLoadScene(string sceneAssetName);

        void UnLoadScene(string sceneAssetName, object userData);
    }
}
