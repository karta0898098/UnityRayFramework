using System;

namespace RayFramework.ObjectPool
{
    public interface IObjectPoolManager
    {
        bool HasObjectPool(string key);
        void CreateObjectPool<T>(string key, T prefab, Type type) where T : class;
        ObjectPool<T> GetObjectPool<T>(string key) where T : class;
    }
}
