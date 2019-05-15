using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
	public class UserReportBuilderDirector
	{
		private readonly IUserReportBuilder _builder;

		public UserReportBuilderDirector (IUserReportBuilder builder)
		{
			_builder = builder;
		}

		public void Build ()
		{
			_builder.BuildHeader();
			_builder.BuildBody();
			_builder.BuildFooter();
		}


	}
}
