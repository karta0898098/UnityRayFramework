﻿using System;
using RayFramework.Timer;

namespace UnityRayFramework.Runtime
{
    public sealed class TimerAuto : TimerAutoStartHelper
    {
        public TimerAuto(float target, Action OnComplete) : base(target, OnComplete)
        {
        }

        public TimerAuto(float target, Action OnStart, Action OnComplete) : base(target, OnStart, OnComplete)
        {
        }

        public TimerAuto(float target, Action OnStart, Action OnProcess, Action OnComplete) : base(target, OnStart, OnProcess, OnComplete)
        {
        }
    }
}
