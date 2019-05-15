using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class InMemoryOrderService: IInMemoryService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from InMemoryOrderService");
		}
	}
}
