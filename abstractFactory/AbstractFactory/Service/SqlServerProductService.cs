using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class SqlServerProductService : ISqlServerService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from SqlServerProductService");
		}
	}
}
