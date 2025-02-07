using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    //Write a program that checks if all characters in a given string are unique


    internal class UniqueCharacterString
    {
        public void CheckUniqueCharacterString()
        {
            Console.Write("Enter a String:");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        Console.WriteLine("String has duplicate characters");
                        return;
                       
                    }
                    

                   

                }

            }

            Console.WriteLine("String has unique characters");




        }
    }

}
