using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class OrderServiceFactory : IAbstractFactory
	{
		public IInMemoryService CreateInMemoryServiceInstance ()
		{
			return new InMemoryOrderService();
		}

		public ISqlServerService CreateSqlServiceServiceInstance ()
		{
			return new SqlServerOrderService();
		}
	}
}
