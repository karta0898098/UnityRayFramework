using System;
using System.Collections;
using System.Collections.Generic;
using RayFramework.UI;
using UnityEngine;
using UnityRayFramework.Runtime;

public class UITestController : UIControllerBase
{
    public override IUIController Dispose(Action OnAnimComplete)
    {
        OnAnimComplete?.Invoke();
        return this;
    }

    public override IUIController Init()
    {
        return this;
    }

    public void Call()
    {
        Debug.Log("Call");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
