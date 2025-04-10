using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    //Check for Palindrome Without Loop or String Reverse Function
    public class CheckPalindrome
    {
        public static bool PalindromeNum(int num)
        {

            int op = Reversed(num);

            if (num == op)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static int rev = 0;
        static int Reversed(int num)
        {
 
            if (num > 0)
            { 
                int digit = num % 10;
                rev = rev * 10 + digit;
                Reversed(num / 10);
            
            }
            return rev;

            
        
        }



    }
}

/* FizzBuzz Without Using Loop or If-Else
Print 1 to 100 where:

If divisible by 3: print "Fizz"

If divisible by 5: print "Buzz"

If both: "FizzBuzz"

 
 
 
 
 Find If a Number is a Power of Two Without Using Loop 
Example: 8 → true, 6 → false
 */