namespace builder
{
	public class UserReport
	{
		public string Header { get; set; }
		public string Body { get; set; }
		public string Footer { get; set; }

		public override string ToString ()
		{
			return string.Format("\n{0}\n\n{1}\n\n{2}",Header ,Body ,Footer );
		}

	}
}