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

        [TestCase(new int[0], Helper.even)] // empty integer array
        public void Should_Return_Even_When_Array_Is_Empty(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.oddOrEven(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 1 }, Helper.odd)]
        [TestCase(new int[] { 3 }, Helper.odd)]
        [TestCase(new int[] { 5 }, Helper.odd)]
        public void Should_Return_Odd_When_First_Input_Is_Odd(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.oddOrEven(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 0 }, Helper.even)]
        [TestCase(new int[] { 2 }, Helper.even)]
        [TestCase(new int[] { 4 }, Helper.even)]
        public void Should_Return_Even_When_First_Input_Is_Even(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.oddOrEven(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

        [TestCase(new int[] { 1, 3 }, Helper.even)]
        public void Should_Return_Even_When_Sum_Of_Odd_Inputs_Is_Even(int[] input, string expected)
        {
            // Arrange
            EvenOrOdd evenOrOddKata = new EvenOrOdd();

            // Act
            string output = evenOrOddKata.oddOrEven(input);

            // Assert
            Assert.AreEqual(expected, output);
        }

    }
}