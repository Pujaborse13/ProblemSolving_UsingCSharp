using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    internal class SumOfEvenOddDigit
    {

        public void CalculateSumOfEvenOddDigit()
        {
            Console.Write("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            while (input != 0)
            {
                int digit = input % 10;

                if (digit % 2 == 0)
                    evenSum += digit;
                else
                    oddSum += digit;

                input = input / 10;

            
            }

            Console.WriteLine($"Sum of Even Digits: {evenSum}");
            Console.WriteLine($"Sum of Odd Digits: {oddSum}");

        }
    }
}
