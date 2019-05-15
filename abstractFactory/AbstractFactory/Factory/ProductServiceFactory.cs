using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public class ProductServiceFactory : IAbstractFactory
	{
		public IInMemoryService CreateInMemoryServiceInstance ()
		{
			return new InMemoryProductService();
		}

		public ISqlServerService CreateSqlServiceServiceInstance ()
		{
			return new SqlServerProductService();
		}
	}
}
