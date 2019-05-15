using System;

namespace singleton
{
	public class UserService
	{
		static DateTime date;
		static UserService ()
		{
			date = DateTime.Now;
		}
		private UserService ()
		{
		}

		public void Handle ()
		{
			Console.WriteLine("this is from UserService at {0}", date);
		}

		public static UserService Instance { get; } = new UserService();

	}
}
