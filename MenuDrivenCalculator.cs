using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    /* Implement a menu-driven calculator in C# that allows users to perform 
     * basic operations (addition, subtraction, multiplication, division). 
     * Use conditional statements to execute the selected operation and 
     * handle invalid inputs. 
     */

    internal class MenuDrivenCalculator
    {
        public void Calculate()
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.WriteLine("----------------------------");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break;
                }

                int num1, num2;

                Console.WriteLine("Enter the First Number");
                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }


                Console.WriteLine("Enter the Second Number");
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                switch (choice)
                {

                    case "1":
                        Console.WriteLine($"Addition: {num1 + num2}");
                        break;

                    case "2":
                        Console.WriteLine($"Subtraction: {num1 - num2}");
                        break;

                    case "3":
                        Console.WriteLine($"Multiplication: {num1 * num2}");
                        break;

                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine($"Division Result: {(double)num1 / num2}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting the Program");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }


            }

        }
    }
}
