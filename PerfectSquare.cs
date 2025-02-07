using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    internal class PerfectSquare
    {
        public void PerfectSquareCheck()
        { 
            Console.Write("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            double sqrt = Math.Sqrt(input);
            if (sqrt * sqrt == input)
            {
                Console.WriteLine($"{input} is a perfect square");
            }

            else {

                Console.WriteLine($"{input} is not Perfect Square");

            }



        }



    }
}
