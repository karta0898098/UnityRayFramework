using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRayFramework.Runtime;

public class Test : MonoBehaviour
{
    AudioComponent Audio;

    void Start()
    {
        Audio = RayFrameworkEntry.GetComponent<AudioComponent>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Audio.PlaySFX("Aluminum_Can_Open", transform);
        }
    }
}
