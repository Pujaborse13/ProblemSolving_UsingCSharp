using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    //Find If a Number is a Power of Two Without Using Loop  , Example: 8 → true, 6 → false
    // 2^1 = 2 , 2^2= 4 , 2^3 = 8

    

    public class PowerOfTwo
    {

        public static bool IsPowerofTwo(int num)  // only working for perfect squre num
        {
            if (num % 2 == 0)
            {
               double result = Math.Sqrt(num);

                if (result == Math.Floor(result))
                 { 
                    return IsPowerofTwo((int)result);
                }
                return false;
            }

            else
            {
                return false;
            }

        
        
        }



        public static bool IsPowerofTwoModified(double num)
        {

            if (num <= 0) 
                return false;

            if (num == 1) 
                return true;

            if (num % 2 != 0)
                return false;

        return IsPowerofTwoModified(num / 2);
        
        
        }


       
    }
}
