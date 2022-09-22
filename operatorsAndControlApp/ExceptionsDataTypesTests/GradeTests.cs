using ExceptionsApp;
using NUnit.Framework;
using System;

namespace ExceptionsDataTypesTests
{
    public class Tests
    {
        
        [TestCase(-30)]
        [TestCase(-1)]
        public void UnderZeroGradeArgumentException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Allowed range 0-100"));
        }

        [TestCase(101)]
        [TestCase(200)]
        public void AboveHundredGradeArgumentException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Allowed range 0-100"));
        }
    }
}