using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
	public class UserReportBuilder : IUserReportBuilder
	{
		private UserReport _report;

		private string _head, _body, _footer = string.Empty;

		public UserReportBuilder (string head, string body, string footer)
		{
			_report = new UserReport();
			_head = head;
			_body = body;
			_footer = footer;
		}
		
		public void BuildHeader ()
		{
			_report.Header = string.Format(" Header:\n {0}", _head);
		}

		public void BuildBody ()
		{
			_report.Body = string.Format(" Body:\n {0}", _body);
		}

		public void BuildFooter ()
		{
			_report.Footer = string.Format(" Footer:\n {0}", _footer);
		}


		public UserReport GetReport ()
		{
			return _report;
		}
	}
}
