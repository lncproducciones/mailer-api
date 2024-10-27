using Microsoft.AspNetCore.Mvc;

namespace mailer_api.Controllers
{
	[Route("mailer")]
	[ApiController]
	public class MailerController : ControllerBase
	{
		[Route("send")]
		[HttpPost]
		public bool SendEmail([FromBody] Types.SendMessageParemeters p)
		{ 
			return MailerService.SendEmail(p);
		}
	}
}
