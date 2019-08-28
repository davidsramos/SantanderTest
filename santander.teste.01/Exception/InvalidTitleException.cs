using System;
using System.Runtime.Serialization;

namespace santander.teste._01.Exception
{
    [Serializable]
    public class InvalidTitleException : FormatException
    {
        public InvalidTitleException()
            : base("Invalid title, length must be between 1 and 20 characters")
        {

        }

    }
}
