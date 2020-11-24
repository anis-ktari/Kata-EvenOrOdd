using System;

namespace EvenOrOddKata
{
    class program
    {
        static void Main(string[] args)
        {
            int[] empty_array = new int[0];
            int[] input2 = new int[] { 2, 5, 34, 6 };
            int[] input3 = new int[] { 0, -1, -5 };

            EvenOrOdd evenOrOdd = new EvenOrOdd();

            string result1 = evenOrOdd.oddOrEven(empty_array);
            string result2 = evenOrOdd.oddOrEven(input2);
            string result3 = evenOrOdd.oddOrEven(input3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
