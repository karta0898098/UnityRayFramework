using System;

namespace RayFramework
{
    public abstract class ObjectPoolBase
    {
        public string Name { get; private set; }

        public DateTime LastUseTime{ get; internal set; }

        protected internal virtual void NewObject(string name, DateTime lastUseTime)
        {
            Name = name;
            LastUseTime = lastUseTime;
        }

        protected internal abstract void Release(bool isShutdown);
    }
}
