using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;
using Math = System.Math;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;

        [SetUp]
        public void Setup()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }
        [Test]
        [TestCase(-1)]
        [TestCase(400)]
        public void CalculateDemeritPoints_SpeedLessThan0OrMaxSpeedExceeded_ThrowOutOfRangeException(int speed)
        {
            //Arrange 
           // var demeritsCalculator = new DemeritPointsCalculator();
            //Act
           // var result = demeritsCalculator.CalculateDemeritPoints(speed);
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(50, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            //Arrange
            //var demeritsCalculator = new DemeritPointsCalculator();
            //Act 
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        //[Test]
        //[TestCase(70, 1)]
        //[TestCase(80, 3)]
        //public void CalculateDemeritPoints_SpeedGreaterThanSpeedLimit_ReturnDemeritPoints(int speed, int expectedResult)
        //{
        //    //Arrange
        //    //var demeritsCalculator = new DemeritPointsCalculator();
        //    //Act
        //    var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);
        //    //Assert
        //    Assert.That(result, Is.EqualTo(expectedResult));
        //}

    }
}
