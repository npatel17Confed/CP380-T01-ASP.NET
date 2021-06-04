using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsItALeapYear;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Year_2001_Is_Not_A_Leap_Year()
        {
            // Arrange
            var p = new Program();
            var expected = false;
            // Act
            var actual = p.IsItALeapYear(2001);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_1996_Is_Not_A_Leap_Year()
        {
            // Arrange
            var p = new Program();
            var expected = true;
            // Act
            var actual = p.IsItALeapYear(1996);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_1900_Is_Not_A_Leap_Year()
        {
            // Arrange
            var p = new Program();
            var expected = false;
            // Act
            var actual = p.IsItALeapYear(1900);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Year_2000_Is_Not_A_Leap_Year()
        {
            // Arrange
            var p = new Program();
            var expected = true;
            // Act
            var actual = p.IsItALeapYear(2000);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
