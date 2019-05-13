using System;
using RayFramework.ObjectPool;
using UnityRayFramework.Runtime;

namespace UnityRayFramework.Runtime
{
    public class ObjectPoolComponent : RayFrameworkComponent
    {
        private IObjectPoolManager m_ObjectPoolManager;

        protected override void Awake()
        {
            base.Awake();

            m_ObjectPoolManager = RayFramework.RayFrameworkEntry.GetModule<IObjectPoolManager>();
        }

        public bool HasObjectPool(string key)
        {
            return m_ObjectPoolManager.HasObjectPool(key);
        }

        public void CreateObjectPool<T>(string key, T prefab, Type type) where T : class
        {
            m_ObjectPoolManager.CreateObjectPool(key,prefab,type);
        }

        public ObjectPool<T> GetObjectPool<T>(string key) where T :class
        {
            return m_ObjectPoolManager.GetObjectPool<T>(key);
        }
    }
}
