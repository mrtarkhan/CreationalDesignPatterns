using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
	internal class ProductServiceFactory : IFactory
	{
		public IService CreateInstance ()
		{
			return new ProductService();
		}
	}
}
