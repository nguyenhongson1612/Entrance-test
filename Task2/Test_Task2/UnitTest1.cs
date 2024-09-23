using Task2;

namespace SumOfTopTwoTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestCase1()
        {
            var arr = new List<int> { 1, 4, 2, 3, 5 };
            int expected = 9;
            int result = Program.SumOfTopTwoIntegers(arr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            var arr = new List<int> { 10, 20, 30, 40 };
            int expected = 70;
            int result = Program.SumOfTopTwoIntegers(arr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNegativeNumbers()
        {
            var arr = new List<int> { -1, -2, -3, -4 };
            int expected = -3;
            int result = Program.SumOfTopTwoIntegers(arr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestExactlyTwoNumbers()
        {
            var arr = new List<int> { 100, 200 };
            int expected = 300;
            int result = Program.SumOfTopTwoIntegers(arr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArrayWithOneNumber()
        {
            var arr = new List<int> { 1 };
            Program.SumOfTopTwoIntegers(arr); // Expected to throw an exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyArray()
        {
            var arr = new List<int> { };
            Program.SumOfTopTwoIntegers(arr); // Expected to throw an exception
        }
    }
}
