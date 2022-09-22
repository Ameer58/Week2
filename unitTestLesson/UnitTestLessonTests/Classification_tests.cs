using NUnit.Framework;
using System;
using unitTestLessonApp;

namespace UnitTestLessonTests
{
    class Classification_tests
    {
        [Test]
        [TestCase(11)]
        [TestCase(5)]
        [TestCase(1)]
        public void Viewer_Under_12_WithoutAdult(int age)
        {
            //Arange
            Boolean adult = false;
            string output;
            //Act
            output = Program.AvailableClassifications(age, adult);
            //Assert
            Assert.That(output, Is.EqualTo("U & PG films are available."));

        }
        
        [Test]
        [TestCase(11)]
        [TestCase(5)]
        [TestCase(1)]
        public void Viewer_Under_12_WithAdult(int age)
        {
            //Arange
            Boolean adult = true;
            string output;
            //Act
            output = Program.AvailableClassifications(age, adult);
            //Assert
            Assert.That(output, Is.EqualTo("U, PG & 12 films are available."));

        }

        [Test]
        [TestCase(13)]
        [TestCase(12)]
        [TestCase(14)]
        public void Viewer_Over_12_Under_15(int age)
        {
            //Arange
            Boolean adult = false;
            string output;
            //Act
            output = Program.AvailableClassifications(age, adult);
            //Assert
            Assert.That(output, Is.EqualTo("U, PG & 12 films are available."));

        }

        [Test]
        [TestCase(15)]
        [TestCase(17)]
        [TestCase(16)]
        public void Viewer_Over_15_Under_18(int age)
        {
            //Arange
            Boolean adult = false;
            string output;
            //Act
            output = Program.AvailableClassifications(age, adult);
            //Assert
            Assert.That(output, Is.EqualTo("U, PG, 12 & 15 films are available."));

        }

        [Test]
        [TestCase(18)]
        [TestCase(90)]
        [TestCase(30)]
        public void Viewer_Over18(int age)
        {
            //Arange
            Boolean adult = false;
            string output;
            //Act
            output = Program.AvailableClassifications(age, adult);
            //Assert
            Assert.That(output, Is.EqualTo("All films are available."));

        }

    }
}
