using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLasErrorProperty()
        {
            //Arrange 
            var logger = new ErrorLogger();
            //Act
            logger.Log("a");
            //Assert
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //Arrange
            var logger = new ErrorLogger();
            //Act
            //logger.Log(error);
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaisedErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args;};
            logger.Log("a");


            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
