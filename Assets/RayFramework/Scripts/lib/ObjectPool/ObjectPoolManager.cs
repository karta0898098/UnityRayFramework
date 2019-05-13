using System;
using System.Collections.Generic;

namespace RayFramework.ObjectPool
{
    public class ObjectPoolManager:RayCoreModule,IObjectPoolManager 
    {
        public Dictionary<string, ObjectPoolBase> m_ObjectPools;

        public ObjectPoolManager()
        {
            m_ObjectPools = new Dictionary<string, ObjectPoolBase>();
        }

        public bool HasObjectPool(string key)
        {
            return m_ObjectPools.ContainsKey(key);
        }

        public void CreateObjectPool<T>(string key,T prefab,Type type) where T : class
        {
            if (m_ObjectPools.ContainsKey(key))
            {
                return;
            }

            var objectPool = Activator.CreateInstance(type) as ObjectPool<T>;
            objectPool.SetPrefab(prefab);
            objectPool.NewObject(key,DateTime.Now);
            m_ObjectPools.Add(key,objectPool);
        }

        public ObjectPool<T> GetObjectPool<T>(string key) where T : class
        {
            m_ObjectPools.TryGetValue(key, out var objectPool);
            return objectPool as ObjectPool<T>;
        }

        internal override void Update(float timeTick, float realTimeTick)
        {

        }

        internal override void Shoudown()
        {

        }
    }
}
