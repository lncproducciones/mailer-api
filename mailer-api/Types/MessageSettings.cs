namespace mailer_api.Types
{
	public class MessageSettings
	{
		public string fromAddress { get; set; }
		public string fromName { get; set; }
		public string toAddress { get; set; }
		public string toName { get; set; }
		public string subject { get; set; }
		public string body { get; set; }
		public bool isHtml { get; set; }
	}
}
