using System;

namespace RayFramework
{
    public interface ISceneLoaderHelper
    {
        void LoadScene(string sceneAssetName, Action success, Action<float> progess, Action failed);
    }
}
