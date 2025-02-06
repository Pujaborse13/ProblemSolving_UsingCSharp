using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingUsingCSharp
{
    /* Design a simple login system in C# where users provide their username and password. 
     * Use conditional statements to check the credentials and provide appropriate feedback, 
     * such as successful login, incorrect username, incorrect password, or account locked.
     */


    internal class LoginSystem
    {
        const int MAX_ATTEMPTS = 3;
        const string VALID_USERNAME = "admin";
        const string VALID_PASSWORD = "puja";
        public void LogIn()
        {
            for (int i = 0; i < MAX_ATTEMPTS; i++)
            {
                Console.Write("Enter the Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter the Password :");
                string password = Console.ReadLine();


                if (username == VALID_USERNAME && password == VALID_PASSWORD)
                {
                    Console.WriteLine("Login Successful");
                    return;
                }

                else if (username != VALID_USERNAME)
                {
                    Console.WriteLine("Incorrect Username");
                }

                else if(password != VALID_PASSWORD)
                {
                    Console.WriteLine("Incorrect Password");
                }
                Console.WriteLine($"Attempts left: {MAX_ATTEMPTS - i - 1}");

            }
               
         Console.WriteLine("Account Locked");
              
        }

    }
}
