using System.Linq;

namespace EvenOrOddKata
{
    public class EvenOrOdd
    {
        public string oddOrEven(int[] input)
        {
            if (IsArrayEmpty(input)) // array is empty
                return Helper.even;

            if (IsInputEven(input.Sum()))
                return Helper.even;
            return Helper.odd;
        }

        private static bool IsArrayEmpty(int[] input)
        {
            return input.Length == 0;
        }

        private static bool IsInputEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
