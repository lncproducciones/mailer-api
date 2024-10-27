namespace mailer_api.Types
{
	public class SendMessageParemeters
	{
		public MailerSettings settings { get; set; }
		public MessageSettings msg { get; set; }
	}
}
