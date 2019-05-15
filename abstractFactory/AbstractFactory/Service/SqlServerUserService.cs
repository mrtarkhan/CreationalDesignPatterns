using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class SqlServerUserService : ISqlServerService
	{
		public void Handle ()
		{
			Console.WriteLine("this is from SqlServerUserService");
		}
	}
}
