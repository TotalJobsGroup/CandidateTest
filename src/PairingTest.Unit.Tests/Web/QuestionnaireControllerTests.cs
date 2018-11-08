using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        private Mock<IConfiguration> _config;
        private QuestionnaireController _questionnaireController;

        [SetUp]
        public void SetUp()
        {
            _config = new Mock<IConfiguration>();
            _questionnaireController = new QuestionnaireController(_config.Object);
        }

        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected quesitons";

            //Act
            var result = (QuestionnaireViewModel)_questionnaireController.Index().ViewData.Model;

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}