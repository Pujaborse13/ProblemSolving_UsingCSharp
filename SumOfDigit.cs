using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    //Sum of Digits Without Loop
    public class SumOfDigit
    {
        public static int sumDigit( int num)
        {
            if (num == 0)
            {
                return 0;
            }

            else {
                int digit = num % 10;
                num = num / 10;
                int sum = digit + sumDigit(num);
                return sum;
            
            }


            //int digit = num % 10;
            //num  = num/10
            //int sum = digit  + num
        
        }




    }
}
