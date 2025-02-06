using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Develop a C# program that calculates the Air Quality Index (AQI) based 
 * on the concentration of pollutants. Use conditional statements to classify 
 * the AQI into different categories (Good, Moderate, Unhealthy, etc.) based 
 * on predefined thresholds for different pollutants.
*/

namespace ProblemSolvingUsingCSharp
{
    internal class CalculateAirQualityIndex
    {
        public void CalculateAQI()
        {
            Console.Write("Enter PM2.5 Concetration (in ug/m3): ");
            int pm25;

            if (!int.TryParse(Console.ReadLine(), out pm25))
            {
                Console.WriteLine("Invalid Input");
                return;
            }


            int aqi;
            if (pm25 <= 12)
                aqi = 50; // Good

            else if (pm25 <= 35)
                aqi = 100; // Moderate

            else if (pm25 <= 55)
                aqi = 150; // Unhealthy for Sensitive Groups

            else if (pm25 <= 150)
                aqi = 200; // Unhealthy

            else if (pm25 <= 250)
                aqi = 300; // Very Unhealthy

            else
                aqi = 400; // Hazardous

            string category = GetAQICategory(aqi);
            Console.WriteLine($"AQI: {aqi}, Category: {category}");
        }
            private string GetAQICategory(int aqi)
            {
                if (aqi <= 50) return "Good";
                if (aqi <= 100) return "Moderate";
                if (aqi <= 150) return "Unhealthy for Sensitive Groups";
                if (aqi <= 200) return "Unhealthy";
                if (aqi <= 300) return "Very Unhealthy";
                return "Hazardous";
            }



    }
}
