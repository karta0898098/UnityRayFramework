using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRayFramework.Runtime;

public class Test : MonoBehaviour
{
    AudioComponent Audio;
    UIComponent UI;
    void Start()
    {
        Audio = RayFrameworkEntry.GetComponent<AudioComponent>();
        UI = RayFrameworkEntry.GetComponent<UIComponent>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            UI.Show("Canvas");
        }
    }
}
