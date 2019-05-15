using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main (string[] args)
		{
			var userFactory = new UserServiceFactory();
			var orderFactory = new UserServiceFactory();
			var productFactory = new UserServiceFactory();
			
			var inMemoryUserService = userFactory.CreateInMemoryServiceInstance();
			var inMemoryOrderService = orderFactory.CreateInMemoryServiceInstance();
			var inMemoryProductService = productFactory.CreateInMemoryServiceInstance();


			var sqlServerUserService = userFactory.CreateSqlServiceServiceInstance();
			var sqlServerOrderService = orderFactory.CreateSqlServiceServiceInstance();
			var sqlServerProductService = productFactory.CreateSqlServiceServiceInstance();

			
			inMemoryUserService.Handle();
			inMemoryOrderService.Handle();
			inMemoryProductService.Handle();

			
			sqlServerUserService.Handle();
			sqlServerOrderService.Handle();
			sqlServerProductService.Handle();



			Console.ReadLine();

		}
	}
}
