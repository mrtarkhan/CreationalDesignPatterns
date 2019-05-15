using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
	public interface IUserReportBuilder
	{
			void BuildHeader ();
			void BuildBody ();
			void BuildFooter ();
			UserReport GetReport ();
	}
}
