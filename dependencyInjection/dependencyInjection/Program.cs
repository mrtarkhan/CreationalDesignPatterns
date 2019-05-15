using System;

namespace dependencyInjection
{
	class Program
	{
		static void Main (string[] args)
		{
			Container.Register<IUserRepository>(new UserRepository());
			var userRepository = Container.Resolve<IUserRepository>();
			Container.Register<IUserService>(new UserService(userRepository));
			var userService = Container.Resolve<IUserService>();

			userService.Handle();
			Console.WriteLine("press any key to exit");
			Console.ReadLine();

		}
	}
}
