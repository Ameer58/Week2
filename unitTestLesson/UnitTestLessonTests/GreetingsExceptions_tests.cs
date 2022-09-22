using System;

using NUnit.Framework;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    internal class GreetingsExceptions_tests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-20)]
        public void ZeroAndLowerArgumentException(int time)
        {
            Assert.That(() => Program.GetGreeting(time), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Not a valid time"));
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        [TestCase(100)]
        public void Over24ArgumentException(int time)
        {
            Assert.That(() => Program.GetGreeting(time), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Not a valid time"));
        }
    }
}
