using System;

namespace factoryMethod
{
    public interface IFactory
    {
        IService CreateInstance();
    }
}