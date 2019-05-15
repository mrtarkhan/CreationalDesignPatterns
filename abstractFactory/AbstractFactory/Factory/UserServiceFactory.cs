using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class UserServiceFactory : IAbstractFactory
	{
		public IInMemoryService CreateInMemoryServiceInstance ()
		{
			return new InMemoryUserService();
		}

		public ISqlServerService CreateSqlServiceServiceInstance ()
		{
			return new SqlServerUserService();
		}
	}
}
