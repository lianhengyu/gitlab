using NUnit.Framework;
using WebApplication1.Controllers;
using System.Web.Mvc;

namespace WebApplication1.UnitTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_ReturnsViewResult()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.Fail("This test should always fail.");
        }

        [Test]
        public void About_ReturnsViewResultWithMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.About();

            // Assert
            Assert.Fail("This test should always fail.");
        }

        [Test]
        public void Contact_ReturnsViewResultWithMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.Contact();

            // Assert
            Assert.Fail("This test should always fail.");
        }
    }
}
