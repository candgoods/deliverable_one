using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a password with the following requirements: \n");
            Console.WriteLine("At least one lowercase letter");
            Console.WriteLine("At least one uppercase letter");
            Console.WriteLine("Minimum of 7 characters");
            Console.WriteLine("Maximum of 12 characters");
            Console.WriteLine("An exclamation point: !\n");

            string userPassword = Console.ReadLine();

            //debug tests below - to be removed after testing
            //Console.WriteLine(userPassword);
            //Console.WriteLine(userPassword.Any(char.IsUpper));
            //Console.WriteLine(userPassword.Any(char.IsLower));
            //Console.WriteLine(userPassword.Length >= 7);
            //Console.WriteLine(userPassword.Length <= 12);
            //Console.WriteLine(userPassword.Contains("!"));

            if (userPassword.Any(char.IsUpper) && userPassword.Any(char.IsLower)
                && userPassword.Length>=7 && userPassword.Length<=12
                && userPassword.Contains("!"))
            {
                Console.WriteLine("Password is valid and accepted");
            } else
            {
                Console.WriteLine("ERROR");
            }








        }
    }
}
