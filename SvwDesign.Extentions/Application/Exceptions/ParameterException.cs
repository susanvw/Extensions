﻿using System;

namespace SvwDesign.Extensions.Exceptions
{
    public class ParameterException : Exception
    {
        public ParameterException()
            : base()
        {
        }

        public ParameterException(string message)
            : base(message)
        {
        }

        public ParameterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ParameterException(string name, object key)
            : base($"Parameter \"{name}\" ({key}) is not valid.")
        {
        }
    }
}
