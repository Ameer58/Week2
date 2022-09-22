using System;
using NUnit.Framework;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    internal class ClassificationExceptions_tests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-200)]
        public void Age_0AndBelow_Exception(int age)
        {
            Boolean adult = false;
            Assert.That(() => Program.AvailableClassifications(age, adult), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Age from 1-200"));
        }

        [Test]
        [TestCase(201)]
        [TestCase(300)]
        [TestCase(250)]
        public void Age_200Above_Exception(int age)
        {
            Boolean adult = false;
            Assert.That(() => Program.AvailableClassifications(age, adult), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Age from 1-200"));
        }
    }
}
