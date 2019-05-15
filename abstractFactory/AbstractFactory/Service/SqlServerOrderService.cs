using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	class SqlServerOrderService : ISqlServerService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from SqlServerOrderService");
		}
	}
}
