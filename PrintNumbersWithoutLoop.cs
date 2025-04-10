using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    //Print 1 to 100 Without Using Loops
    public class PrintNumbersWithoutLoop
    {
        
        public static void numberInRange(int num)
        {

            if (num <= 100)
            {
                Console.WriteLine(num);
                numberInRange(num + 1);

            }
            return;
        }


    }
}
