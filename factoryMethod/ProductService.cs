using System;

namespace factoryMethod
{
	internal class ProductService : IService
	{
        public void Handle() {
            Console.WriteLine("this is from ProductService");
        }
	}
}