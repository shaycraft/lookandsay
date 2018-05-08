using System;

namespace lookandsay
{
    public class Program
    {
        private const int NUM_ITERATIONS = 10;
        public static void Main(string[] args)
        {
            string number = "1";
            for (int iter = 0; iter < NUM_ITERATIONS; iter++)
            {
                string newNumber = "";
                int digit = Int32.Parse(number.Substring(0, 1));
                int currDigit = digit;
                int digitCount = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    ++digitCount;
                    currDigit = Int32.Parse(number.Substring(i, 1));
                    if (currDigit != digit)
                    {
                        newNumber += calculate_digits(digit, digitCount - 1);
                        digit = currDigit;
                        digitCount = 1;
                    }
                }
                newNumber += calculate_digits(currDigit, digitCount);
                number = newNumber;
                Console.WriteLine(number);
            }
        }

        private static string calculate_digits(int digit, int count)
        {
            return count.ToString() + digit.ToString();
        }
    }
}
