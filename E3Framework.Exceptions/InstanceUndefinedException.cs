using System;

namespace E3Framework.Exceptions;

public class InstanceUndefinedException : Exception
{
    public InstanceUndefinedException()
    {
    }

    public InstanceUndefinedException(string message) : base(message)
    {
    }

    public InstanceUndefinedException(string message, Exception inner) : base(message, inner)
    {
    }
}