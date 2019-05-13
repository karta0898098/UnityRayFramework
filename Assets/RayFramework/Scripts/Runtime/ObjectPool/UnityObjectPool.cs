using UnityEngine;
using RayFramework.ObjectPool;

namespace UnityRayFramework.Runtime
{
    public abstract class UnityObjectPool<T> : ObjectPool<T> where T : MonoBehaviour
    {

    }
}
