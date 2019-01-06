using System;
using System.Collections;
using System.Collections.Generic;
using RayFramework.UI;
using UnityEngine;
using UnityRayFramework.Runtime;

public class TestController : UIControllerBase
{
    public override IUIController Dispose(Action OnAnimComplete)
    {
        return this;
    }

    public override IUIController Init()
    {
        return this;
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
