using System.Net;
using System.Net.Mail;

namespace mailer_api
{
	public class MailerService
	{
		/// <summary>
		/// Simple email sending proccess.
		/// </summary>
		/// <param name="p">Message parameters and server configuration.</param>
		/// <returns></returns>
		public static bool SendEmail(Types.SendMessageParemeters p)
		{
			try
			{
				using (SmtpClient sender = new SmtpClient
				{
					Host = p.settings.server,
					Port = p.settings.port,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential
					{
						UserName = p.settings.userName,
						Password = p.settings.password
					}
				})
				{
					MailMessage msg = new MailMessage
					{
						From = new MailAddress(p.msg.fromAddress, p.msg.fromName),
						Subject = p.msg.subject,
						Body = p.msg.body,
						IsBodyHtml = p.msg.isHtml
					};
					msg.To.Add(new MailAddress(p.msg.toAddress, p.msg.fromName));

					sender.Send(msg);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
