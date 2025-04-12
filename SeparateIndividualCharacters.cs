using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ProblemSolving
{
    public class SeparateIndividualCharacters
    {
        static string input;


        public static void SeparateIndividualCharactersFromStr()
        {
         
            Console.WriteLine("Enter the input string");
            input = Console.ReadLine();

            foreach (char ch in input)
            { 
                Console.Write(ch+ " ");
            }

        }


        public static void SeparateIndividualCharactersInRevOrder()
        {
            Console.WriteLine("Enter the input string");
            input = Console.ReadLine();

            int len = input.Length-1;
            

            for(int i = len ; i >= 0;i--)
            {
                Console.Write(input[i]+ " ");
            }

        }


    }
}
