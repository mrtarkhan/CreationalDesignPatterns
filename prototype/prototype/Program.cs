using System;

namespace prototype
{
	class Program
	{
		static void Main (string[] args)
		{
			var user = new User();
			user.Name = "Mohammadreza Tarkhan";
			user.Age = 20;

			var address = new Address();
			address.City = "Tehran";
			address.Country = "Iran";
			user.Address = address;

			Console.WriteLine("{0}: {1} - {2}", user.Name, user.Age, user.Address.City);
			var newShallowUser = user.ShallowCopy();
			user.Name = "Bernard Someson";
			address.City = "NY";
			Console.WriteLine("{0}: {1} - {2}", newShallowUser.Name, newShallowUser.Age, newShallowUser.Address.City);


			var deepCopy = user.DeepCopy();
			user.Name = "Behnam Baziyar";
			address.City = "London";
			Console.WriteLine("{0}: {1} - {2}", deepCopy.Name, deepCopy.Age, deepCopy.Address.City);

			Console.WriteLine("press any key to exit");
			Console.ReadLine();


		}
	}
}
