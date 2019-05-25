using System.ComponentModel.DataAnnotations;

namespace ContactForm.Model
{
	public class Message
	{
		public int MessageID { get; set; }

		[Required]
		[EmailAddress]
		public string FromEmail { get; set; }

		[Required]
		public string FromName { get; set; }

		public string Text { get; set; }
	}
}
