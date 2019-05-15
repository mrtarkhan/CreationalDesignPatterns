using System;

namespace factoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
			var userFactory = new UserServiceFactory();
			var userService = userFactory.CreateInstance();
			userService.Handle();

			
			var orderFactory = new OrderServiceFactory();
			var orderService = orderFactory.CreateInstance();
			orderService.Handle();

			
			var productFactory = new ProductServiceFactory();
			var productService = productFactory.CreateInstance();
			productService.Handle();

			Console.ReadLine();
        }
    }
}
