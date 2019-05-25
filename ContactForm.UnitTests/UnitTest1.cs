using System;
using System.Threading.Tasks;
using Xunit;

namespace ContactForm.UnitTests
{
	public class UnitTest1
	{
		//[Fact]
		//public async Task MessagesPost_ReturnsBadRequestResult_WhenModelStateIsInvalid()
		//{
		//	// Arrange
		//	var mockRepo = new Mock<IBrainstormSessionRepository>();
		//	mockRepo.Setup(repo => repo.ListAsync())
		//		.ReturnsAsync(GetTestSessions());
		//	var controller = new MessagesController(mockRepo.Object);
		//	controller.ModelState.AddModelError("SessionName", "Required");
		//	var newSession = new HomeController.NewSessionModel();

		//	// Act
		//	var result = await controller.Index(newSession);

		//	// Assert
		//	var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
		//	Assert.IsType<SerializableError>(badRequestResult.Value);
		//}

		//[Fact]
		//public async Task IndexPost_ReturnsARedirectAndAddsSession_WhenModelStateIsValid()
		//{
		//	// Arrange
		//	var mockRepo = new Mock<IBrainstormSessionRepository>();
		//	mockRepo.Setup(repo => repo.AddAsync(It.IsAny<BrainstormSession>()))
		//		.Returns(Task.CompletedTask)
		//		.Verifiable();
		//	var controller = new HomeController(mockRepo.Object);
		//	var newSession = new HomeController.NewSessionModel()
		//	{
		//		SessionName = "Test Name"
		//	};

		//	// Act
		//	var result = await controller.Index(newSession);

		//	// Assert
		//	var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
		//	Assert.Null(redirectToActionResult.ControllerName);
		//	Assert.Equal("Index", redirectToActionResult.ActionName);
		//	mockRepo.Verify();
		//}
	}
}
