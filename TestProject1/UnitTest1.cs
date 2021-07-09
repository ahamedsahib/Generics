using GenericsProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MaxOfThree max;


        [TestInitialize]
        public void SetUp()
        {
            max = new MaxOfThree();
        }
        
        public void MaxInt()
        {
            int num1, num2, num3, actual, expected;
            //TC 1.1
            //Arrange
            num1 = 45; num2 = 35; num3 = 40;
            expected = num1;
            //Act
            actual = max.MaxOfThreeNumbersInteger(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //TC 1.2
            //Arrange
            num1 = 35; 
            num2 = 45; 
            num3 = 40;
            expected = num2;
            //Act
            actual = max.MaxOfThreeNumbersInteger(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
            //TC 1.3
            //Arrange
            num1 = 35;
            num2 = 40; 
            num3 = 45;
             expected = num3;
            //Act
            actual = max.MaxOfThreeNumbersInteger(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MaxString()
        {
            string num1, num2, num3, actual, expected;
            //TC 1.1
            //Arrange
            num1 = "xyz"; num2 = "abc"; num3 = "pqr";
            expected = num1;
            //Act
            actual = max.MaxOfThreeNumbersString(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);

            //TC 1.2
            //Arrange
            num1 = "bde";
            num2 = "qwr";
            num3 = "hki";
            expected = num2;
            //Act
            actual = max.MaxOfThreeNumbersString(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
            //TC 1.3
            //Arrange
            num1 = "abc";
            num2 = "def";
            num3 = "ghi";
            expected = num3;
            //Act
            actual = max.MaxOfThreeNumbersString(num1, num2, num3);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
