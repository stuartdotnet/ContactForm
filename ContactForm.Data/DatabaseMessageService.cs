using ContactForm.Model;
using System.Threading.Tasks;

namespace ContactForm.Data
{
	public class DatabaseMessageService : IMessageService
	{
		private readonly ContactFormContext _context;

		public DatabaseMessageService(ContactFormContext context)
		{
			_context = context;
		}

		public async Task SaveMessage(Message message)
		{
			_context.Messages.Add(message);
			await _context.SaveChangesAsync();
		}
	}
}
