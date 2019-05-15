using System;

namespace simpleFactory
{
    class Program
    {
		static void Main (string[] args)
		{
			var factory = new SimpleFactory();
			var service = factory.CreateInstance(ServiceType.ProductService);
			service.Handle();
			service = factory.CreateInstance(ServiceType.OrderService);
			service.Handle();
			service = factory.CreateInstance(ServiceType.UserService);
			service.Handle();
			Console.ReadLine();

		}
    }
}
