using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRayFramework.Runtime;

public class Test : MonoBehaviour
{
    ResoureComponent resoure;
    UIComponent UI;

    void Start()
    {
        resoure = RayFrameworkEntry.GetComponent<ResoureComponent>();
        UI = RayFrameworkEntry.GetComponent<UIComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            UI.Show<UITestController>("Canvas", (ui) => { ui.Call(); });
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            UI.Close("Canvas");
        }
    }
}
