using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class InMemoryUserService : IInMemoryService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from InMemoryUserService");
		}
	}
}
