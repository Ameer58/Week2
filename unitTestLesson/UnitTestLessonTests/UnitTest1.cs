using NUnit.Framework;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    public class Tests
    {
     
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