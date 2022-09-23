using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op_CtrlFlow_Tests
{
    internal class Exercises_Exceptions_Tests
    {
        [Test]

        public void ExceptionError_EmptyList()
        {
            List<int> nums = new List<int>();
            Assert.That(() => Exercises.Average(nums), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Invalid List"));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-20)]
        public void InvalidAgeForTicketException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Not a valid age"));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(101)]
        public void InvalidGradeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Invalid mark, 0-100"));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(5)]
        public void InvalidAlertLevelException(int level)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(level), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Invalid level, 0-4"));
        }

    }
}
