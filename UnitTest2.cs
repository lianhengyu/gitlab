using NUnit.Framework;
using WebApplication2.Controllers;
using System.Web.Mvc;


namespace WebApplication2.UnitTests
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
            Assert.IsNotNull(result);
            Assert.IsTrue(result is ViewResult);
        }

        [Test]
        public void About_ReturnsViewResultWithMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.About();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is ViewResult);

            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult.ViewBag.Message);
            Assert.AreEqual("Your application description page.", viewResult.ViewBag.Message);
        }

        [Test]
        public void Contact_ReturnsViewResultWithMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.Contact();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is ViewResult);

            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult.ViewBag.Message);
            Assert.AreEqual("Your contact page.", viewResult.ViewBag.Message);
        }
    }
}
