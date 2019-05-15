
using System;

namespace factoryMethod {

	public class UserServiceFactory : IFactory
	{
		public IService CreateInstance ()
		{
			return new UserService();
		}
	}
}