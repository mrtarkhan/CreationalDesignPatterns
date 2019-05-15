using System;

namespace simpleFactory
{
	public class OrderService : IService
	{
		public void Handle ()
		{

			Console.WriteLine("this is from OrderService");
		}
	}
}
