using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
	public class OrderServiceFactory : IFactory
	{
		public IService CreateInstance ()
		{
			return new OrderService();
		}
	}
}
