using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactForm.Data;
using ContactForm.Model;

namespace ContactForm.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ContactFormContext _context;

        public MessagesController(ContactFormContext context)
        {
            _context = context;
        }

        // POST: api/Messages
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.MessageID }, message);
        }
    }
}
