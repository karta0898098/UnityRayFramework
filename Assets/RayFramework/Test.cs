using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRayFramework.Runtime;

public class Test : MonoBehaviour
{
    UIComponent UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = RayFrameworkEntry.GetComponent<UIComponent>();
        //UI.Show<TestController>("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            UI.Show<TestController>("Canvas");
        }
    }
}
