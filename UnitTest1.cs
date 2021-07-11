using GenericsProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MaxOfThree<int> findMaxInt;
        MaxOfThree<string> findMaxString;
        MaxOfThree<double> findMaxDouble;
        MaxOfThree<int> findMaxArray;
        int[] array = { 52, 45, 47, 22, 37 };
        [TestInitialize]
        public void SetUp()
        {
            //arrange
            findMaxInt = new MaxOfThree<int>(10, 20, 30);
            findMaxString = new MaxOfThree<string>("xyz", "poq", "kem");
            findMaxDouble = new MaxOfThree<double>(7.6, 3.6, 7.7);
            findMaxArray = new MaxOfThree<int>(array);

        }
        [TestMethod]
        public void TestMethod1()
        {

            //TC int
            //Arrange
            int expectedInt = 30 ;
            //Act
            int actualInt = findMaxInt.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualInt, expectedInt);

            //TestCase string
            //Arrange
            string expectedString = "xyz";
            //Act
            string actualString = findMaxString.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualString, expectedString);

            //Tc 1.3
            //Arrange
            double expectedDouble = 7.7;
            //Act
            double actualDouble = findMaxDouble.MaxOfThreeNumbers();
            //Assert
            Assert.AreEqual(actualDouble, expectedDouble);


            //Array
            var actual = findMaxArray.FindMaxOfArray();
            var expected = 52;
            Assert.AreEqual(actual, expected);

        }

    }
}