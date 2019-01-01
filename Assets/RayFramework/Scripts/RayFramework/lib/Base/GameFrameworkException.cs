﻿using System;
using System.Runtime.Serialization;

namespace RayFramework
{
    [Serializable]
    public class GameFrameworkException : Exception
    {
        public GameFrameworkException() : base() { }

        public GameFrameworkException(string message) : base(message) { }

        public GameFrameworkException(string message, Exception innerException)
            : base(message, innerException) { }

        protected GameFrameworkException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
