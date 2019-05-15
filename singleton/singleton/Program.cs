using System;
using System.Threading;

namespace singleton
{
	class Program
	{
		static void Main (string[] args)
		{
			UserService.Instance.Handle();
			Thread.Sleep(5000);
			
			UserService.Instance.Handle();
			Thread.Sleep(5000);

			UserService.Instance.Handle();
			Thread.Sleep(5000);
			
			
			UserService.Instance.Handle();
			Thread.Sleep(5000);


			Console.WriteLine("press any key to exit.");
			Console.ReadLine();
		}
	}
}
