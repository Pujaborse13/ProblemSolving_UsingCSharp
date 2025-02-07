using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    //Write a program that calculates the number of workdays (Monday to Friday) between two dates.
    internal class NumberOfWorkdays
    {
        int workDays = 0;
        public void CalculateWorkDays()
        { 
           Console.WriteLine("Enter Start Date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter End Date (yyyy-mm-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            while (startDate <= endDate)
            { 
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                    workDays++;
                startDate = startDate.AddDays(1);
            }
            Console.WriteLine($"Number of Workdays: {workDays}");

        }



    }
}
