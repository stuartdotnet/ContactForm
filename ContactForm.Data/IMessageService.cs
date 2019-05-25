using ContactForm.Model;
using System.Threading.Tasks;

namespace ContactForm.Data
{
	public interface IMessageService
	{
		Task SaveMessage(Message message);
	}
}
