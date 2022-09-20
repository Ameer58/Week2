using NUnit.Framework;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    public class Tests
    {
     
        [Test]
        public void GivenATimeOf2_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 2;
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GivenATimeOf11_GetGreeting_ReturnsGoodMorning()
        {
            //Arrange
            int time = 11;
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good morning!"));
        }

        [Test]
        public void GivenATimeOf13_GetGreeting_ReturnsGoodAfternoon()
        {
            //Arrange
            int time = 13;
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good afternoon!"));
        }

        [Test]
        public void GivenATimeOf21_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 21;
            string output;

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo("Good evening!"));
        }
    }
}