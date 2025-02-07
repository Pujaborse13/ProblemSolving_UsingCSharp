using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{

 /*Write a program that displays the current time in different time zones.*/

    internal class CurrentTimeInDifferentZone
    {
        public void DisplayCurrentTimeInDifferentZone()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Current Time: {dateTime}");

            Console.WriteLine($"Local Time: {DateTime.Now}");
            Console.WriteLine($"India Standard Time (IST): {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "India Standard Time")}");
            Console.WriteLine($"Pacific Standard Time (PST): {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Pacific Standard Time")}");
            Console.WriteLine($"Eastern Standard Time (EST): {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time")}");
            Console.WriteLine($"Central Standard Time (CST): {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Central Standard Time")}");
            Console.WriteLine($"Tokyo Standard Time (JST): {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Tokyo Standard Time")}");














        }
    }
}