using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace BusinessLogicTests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        [DataRow("555-55-5555")]
        [DataRow("555555555")]
        [DataRow("547821693")]
        [DataRow("428-52-1234")]
        public void IsValidSsn_ValidInput_ReturnTrue(string input)
        {
            //Arrange
            bool isValid;
            bool expectedResult = true;

            //Act
            isValid = Validator.IsSsn(input);

            //Assert
            Assert.AreEqual(expectedResult, isValid);
        }

        [TestMethod]
        [DataRow("A")]
        [DataRow("123-123-123")]
        [DataRow("1234567890")]
        [DataRow("TenLetters")]
        public void IsValidSsn_InvalidInput_ReturnsFalse(string input)
        {
            bool isValid;
            bool expectedResult = false;

            //Act
            isValid = Validator.IsSsn(input);

            //Assert
            Assert.AreEqual(expectedResult, isValid);
        }

        [TestMethod]
        [DataRow(10, 1, 10)] //max boundary
        [DataRow(1, 1, 10)] //min boundary
        [DataRow(5, 1, 10)]
        [DataRow(2000, 0, 50000)]
        public void IsWithinRange_NumInInclusiveRange_ReturnTrue(int test, int min, int max)
        {
            //Arrange
            bool isInRange;
            bool expectedResult = true;

            //Act
            isInRange = Validator.IsWithinRange(test, min, max);

            //Assert
            Assert.AreEqual(expectedResult, isInRange);
        }

        [TestMethod]
        [DataRow(4, 5, 10)]
        [DataRow(11, 1, 10)]
        [DataRow(10000, 0, 5000)]
        public void IsWithinRange_NumOutsideInclusiveRange_ReturnsFalse(int test, int min, int max)
        {
            //Arrange
            bool isInRange;
            bool expectedResult = false;

            //Act
            isInRange = Validator.IsWithinRange(test, min, max);

            //Assert
            Assert.AreEqual(expectedResult, isInRange);
        }
    }
}
