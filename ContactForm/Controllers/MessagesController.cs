using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactForm.Data;
using ContactForm.Model;
using System.Net;

namespace ContactForm.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private IMessageService _service;
		public MessagesController(IMessageService service)
		{
			_service = service;
		}

		// POST: api/Messages
		[HttpPost]
		public async Task<ActionResult<Message>> PostMessage(Message message)
		{
			if (!ModelState.IsValid)
			{
				return new BadRequestObjectResult(ModelState);
			}

			await _service.SaveMessage(message);
			return Ok();
		}
	}
}
