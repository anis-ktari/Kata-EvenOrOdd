using System;
using System.Linq;

namespace EvenOrOddKata
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class EvenOrOdd
    {        
        public string CheckEvenOrOddOfNumbersSum(int[] input)
        {
            if (input.Length == 0) // array is empty
                return "Even";
            
            if (input.Sum() % 2 == 0)
                return "Even";
            return "Odd";
        }
    }
}
