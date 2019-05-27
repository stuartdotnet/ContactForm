using ContactForm.Controllers;
using ContactForm.Data;
using ContactForm.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ContactForm.UnitTests
{
	public class MessageControllerTests
	{
		Mock<IMessageService> _mockService;

		public MessageControllerTests()
		{
			_mockService = new Mock<IMessageService>();
		}

		[Fact]
		public async Task MessagesPost_WhenModelStateIsInvalid_ReturnsBadRequestResult()
		{
			// Arrange
			_mockService.Setup(repo => repo.SaveMessage(It.IsAny<Message>()))
				.Returns(Task.CompletedTask);

			var controller = new MessagesController(_mockService.Object);
			controller.ModelState.AddModelError(nameof(Message.FromEmail), "Required");

			// Act
			var result = await controller.PostMessage(It.IsAny<Message>());

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result.Result);
			Assert.IsType<SerializableError>(badRequestResult.Value);
		}

		[Fact]
		public async Task MessagesPost_WhenModelStateIsValid_ReturnsOkResult()
		{
			// Arrange
			var newMessage = new Message { FromEmail = "chris@thesty.com", FromName = "Chris P. Bacon", Text = "Hello" };

			_mockService.Setup(repo => repo.SaveMessage(newMessage))
				.Returns(Task.CompletedTask);

			var controller = new MessagesController(_mockService.Object);

			// Act
			var result = await controller.PostMessage(newMessage);

			// Assert
			Assert.IsType<OkResult>(result.Result);
		}

		[Fact]
		public async Task MessagesPost_WhenNoEmail_ReturnsBadRequestsResult()
		{
			// Arrange
			var newMessage = new Message { FromEmail = null, FromName = "Chris P. Bacon", Text = "Hello" };

			var controller = new MessagesController(_mockService.Object);

			// Act
			controller.SimulateValidation(newMessage);
			var result = await controller.PostMessage(newMessage);

			// Assert
			Assert.IsType<BadRequestObjectResult>(result.Result);
		}

		[Fact]
		public async Task MessagesPost_WhenNameEmpty_ReturnsBadRequestsResult()
		{
			// Arrange
			var newMessage = new Message { FromEmail = "test@test.com", FromName = string.Empty, Text = "Hello" };

			var controller = new MessagesController(_mockService.Object);

			// Act
			controller.SimulateValidation(newMessage);
			var result = await controller.PostMessage(newMessage);

			// Assert
			Assert.IsType<BadRequestObjectResult>(result.Result);
		}
	}
}
