﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;


namespace TestNinja.UnitTests1
{
    [TestFixture]
    class MathTests
    {
        //Setup
        //TearDown
        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math(); 
        }

        [Test]
        [Ignore("Because I wanted to")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrange
            //Act 
            var result =  _math.Add(1, 2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            //Arrange 
            //Act
            var result = _math.Max(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            //Arrange
            //Act
            var result = _math.GetOddNumbers(5);
            //Assert
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));

        }

       
    }
}
