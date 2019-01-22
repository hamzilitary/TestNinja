using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        [TestCase(null)]
        public void Push_ObjectIsNull_ThrowObjectNullException(string T)
        {
            var stack = new Fundamentals.Stack<string>();
            // stack.Push(T);
            Assert.That(() => stack.Push(T), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_AddObjectToList_ReturnWithAddedObjectToStack()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_Returns0()
        {
            var stack = new Fundamentals.Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            //Assert
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WithAFewObjects_ReturnObjectOnTheTop()
        {
            //Arrange (Bringing Object to correct stage before ready for testing)
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            var result = stack.Pop();
            //Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_WithAFewObjects_RemoveObjectOnTheTopOfStack()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            stack.Pop();
            //Assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperatorException()
        {
            var stack = new Fundamentals.Stack<string>();
            // stack.Push(T);
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WithAFewObjects_ReturnsObjectAtTopOfStack()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            var result = stack.Peek();
            //Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_WithAFewObjects_DoesNotRemoveAnyObject()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            stack.Peek();
            //Assert
            Assert.That(stack.Count, Is.EqualTo(3));
        }

    }
}
