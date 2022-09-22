using NUnit.Framework;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    public class Tests
    {
     
        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(4)]
        public void After_Midnight_GetGreeting_ReturnsGoodEvening(int time)
        {
            //Arrange
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good evening!"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenATimeOf5To12_GetGreeting_ReturnsGoodMorning(int time)
        {
            //Arrange
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good morning!"));
        }

        [Test]
        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeOf13To18_GetGreeting_ReturnsGoodAfternoon(int time)
        {
            //Arrange
            
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good afternoon!"));
        }

        [Test]
        [TestCase(21)]
        [TestCase(19)]
        [TestCase(24)]
        public void GivenATimeAfter18_GetGreeting_ReturnsGoodEvening(int time)
        {
            //Arrange
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good evening!"));
        }
    }
}