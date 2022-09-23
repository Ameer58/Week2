using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [Test]
        [TestCase(2,2)]
        [TestCase(3,2)]
        [TestCase(7, 2)]
        public void ReturnFalseIfNumbersAreNotEqualAnd1StNumberIsntMultipleof2nd(int x, int y)
        {
            Boolean output;
            output = Exercises.MyMethod(x, y);
            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        [TestCase(6,2)]
        [TestCase(4, 2)]
        [TestCase(14, 7)]
        public void ReturnTrueIf1stNumberIsMultipleOf2nd(int x, int y)
        {
            Boolean output;
            output = Exercises.MyMethod(x, y);
            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(75)]
        [TestCase(90)]
        [TestCase(100)]
        public void GradeBetween75And100_ReturnsDistinction(int mark)
        {
            string grade = Exercises.Grade(mark);
            Assert.That(grade, Is.EqualTo("Pass with Distinction"));
        }
        [Test]
        [TestCase(74)]
        [TestCase(60)]
        [TestCase(70)]
        public void GradeBetween60And74_ReturnsMerit(int mark)
        {
            string grade = Exercises.Grade(mark);
            Assert.That(grade, Is.EqualTo("Pass with Merit"));
        }
        [Test]
        [TestCase(59)]
        [TestCase(49)]
        [TestCase(40)]
        public void GradeBetween40And59_ReturnsMerit(int mark)
        {
            string grade = Exercises.Grade(mark);
            Assert.That(grade, Is.EqualTo("Pass"));
        }
        [Test]
        [TestCase(39)]
        [TestCase(10)]
        [TestCase(0)]
        public void GradeBelow40_ReturnsFail(int mark)
        {
            string grade = Exercises.Grade(mark);
            Assert.That(grade, Is.EqualTo("Fail"));
        }

        [Test]
        [TestCase(0)]
        public void AlertLevel0Attendes(int level)
        {
            int attendes = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(attendes, Is.EqualTo(200));
        }

        [Test]
        [TestCase(1)]
        public void AlertLevel1Attendes(int level)
        {
            int attendes = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(attendes, Is.EqualTo(100));
        }

        [Test]
        [TestCase(2)]
        public void AlertLevel2Attendes(int level)
        {
            int attendes = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(attendes, Is.EqualTo(50));
        }

        [Test]
        [TestCase(3)]
        public void AlertLevel3Attendes(int level)
        {
            int attendes = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(attendes, Is.EqualTo(50));
        }

        [Test]
        [TestCase(4)]
        public void AlertLevel4Attendes(int level)
        {
            int attendes = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(attendes, Is.EqualTo(20));
        }
    }
}
