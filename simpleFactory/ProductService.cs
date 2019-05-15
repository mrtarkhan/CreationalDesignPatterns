using System;

namespace simpleFactory
{
	public class ProductService : IService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from ProductService");
		}
	}
}
