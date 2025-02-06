using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    /* Write a C# program that calculates the price of a movie ticket based on the 
     * age of the customer and the time of the movie. Implement different pricing rules 
     * for children (under 12), adults (12-64), and seniors (65+), and consider matinee discounts.
     */

    internal class MovieTicketPrice
    {
        public void CalculateTicketPrice()
        {
            Console.Write("Enter the age of the person: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the time of the show: ");
            int time = Convert.ToInt32(Console.ReadLine());

            int price;

            if (age < 12)
            {
                price = 50;
            }

            else if(age >= 12 && age <= 64)
            {
                price = 200;
            }
            else
            {
                price = 100;
            }

            if (time < 18)
            {
                price = price - 25;
            }

            Console.WriteLine($"Ticket Price: ${price}");


        }
    }
}
