using ContactForm.Data;
using ContactForm.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm.UnitTests
{
	public class MessageServiceFake : IMessageService
	{
		// Useful for when we need to test with fake data

		public Task SaveMessage(Message message)
		{
			throw new NotImplementedException();
		}
	}
}
