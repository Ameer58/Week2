using NUnit.Framework;
using operatorsAndControlApp;

namespace operatorsAndControlTest
{
    public class Tests
    {
        [Test]
        [TestCase(14, 1, 0)]
        [TestCase(29, 2, 1)]
        [TestCase(156, 11, 2)]
        public void StonesFrom14Pounds(int pounds, int expected1, int expected2)
        {
            //Arrange
            int output1;
            int output2;
            //Act
            output1 = Stones.GetStones(pounds);
            output2 = Stones.GetPounds(pounds);
            //Assert
            Assert.That(output1, Is.EqualTo(expected1));
            Assert.That(output2, Is.EqualTo(expected2));
        }
    }
}