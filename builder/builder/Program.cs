using System;

namespace builder
{
	class Program
	{
		static void Main (string[] args)
		{
			var builder = new UserReportBuilder("Mohammadreza Tarkhan", "Asp.net Core Crash Course\n from zero to hero", "star me at github");
			var director = new UserReportBuilderDirector(builder);
			director.Build();
			var report = builder.GetReport();
			var result = report.ToString();
			Console.WriteLine(result);

			Console.WriteLine("\n\npress any key to exit...");
			Console.ReadLine();

		}
	}
}
