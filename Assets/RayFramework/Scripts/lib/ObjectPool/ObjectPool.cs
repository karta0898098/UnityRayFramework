using System.Collections.Generic;

namespace RayFramework.ObjectPool
{
    public abstract class ObjectPool<T> : ObjectPoolBase where T:class
    {
        protected T Prefab;

        public void SetPrefab(T Prefab)
        {
            this.Prefab = Prefab;
        }

        public abstract T Spawn();

        public abstract void Unspawn(T obj);
    }
}
