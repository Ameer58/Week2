using NUnit.Framework;
using System;
using operatorsAndControlApp;

namespace operatorsAndControlTest
{
    internal class StonesExceptions_tests
    {
        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        [TestCase(-1)]
        public void InvalidWeightException_GetStones(int pounds)
        {
            Assert.That(() => Stones.GetStones(pounds), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Is not a valid weight"));
        } 

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-50)]
        public void InvalidWeightException_GetPounds(int pounds)
        {
            Assert.That(() => Stones.GetPounds(pounds), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Is not a valid weight"));
        } 
    }
}
