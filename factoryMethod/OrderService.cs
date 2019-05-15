using System;

namespace factoryMethod
{
	internal class OrderService : IService
	{

		public void Handle ()
		{
			Console.WriteLine("this is from OrderService");
		}
	}
}