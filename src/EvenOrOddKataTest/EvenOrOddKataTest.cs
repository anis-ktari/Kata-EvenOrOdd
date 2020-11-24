using EvenOrOddKata;
using NUnit.Framework;

namespace EvenOrOddKataTest
{
    [TestFixture]
    public class EvenOrOddKataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[0], "Even")] // empty integer array
        public void Should_Return_Even_When_Array_Is_Empty(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.CheckEvenOrOddOfNumbersSum(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 1 }, "Odd")]
        [TestCase(new int[] { 3 }, "Odd")]
        [TestCase(new int[] { 5 }, "Odd")]
        public void Should_Return_Odd_When_First_Input_Is_Odd(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.CheckEvenOrOddOfNumbersSum(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 0 }, "Even")]
        [TestCase(new int[] { 2 }, "Even")]
        [TestCase(new int[] { 4 }, "Even")]
        public void Should_Return_Even_When_First_Input_Is_Even(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.CheckEvenOrOddOfNumbersSum(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 1, 3 }, "Even")]
        public void Should_Return_Even_When_Sum_Of_Odd_Inputs_Is_Even(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.CheckEvenOrOddOfNumbersSum(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

    }
}