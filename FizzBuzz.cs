using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    /*FizzBuzz Without Using Loop or If-Else
        Print 1 to 100 where:
        If divisible by 3: print "Fizz"
    If divisible by 5: print "Buzz"
    If both: "FizzBuzz"
    */

    public class FizzBuzz
    {
        public static void printFizzBuzz(int num)
        {
            if (num < 100)
            { 
                string output = (num % 3 == 0 && num % 5 == 0) ? "FizzBuzz" :
                                (num % 3 == 0) ? "Fizz" :
                                (num % 5 == 0) ? "Buzz" : num.ToString();

                //(num % 3 == 0 &&  num % 5 == 0 ) ? "FizzBuzz" : num.ToString();

                Console.WriteLine(output);
                printFizzBuzz(num + 1);


            }
        
        
        }

    }
}
