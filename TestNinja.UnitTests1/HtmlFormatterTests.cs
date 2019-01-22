using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringInStrongElement()
       {
            //Arrange
            var formatter = new HtmlFormatter();
            //Act
            var result = formatter.FormatAsBold("abc");
            //Assert Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            //Assert General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));



        }
    }
}
