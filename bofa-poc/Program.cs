using System;
using bofa_poc.BusinessRules;
using bofa_poc.Contract;

namespace UserValidationApp
{
    class Program
    {
        /// <summary>
        /// This is a simple DEMO with user data validation for BOFA.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // User objects and "biz"
            var user = new UserObject();
            var validator = new UserValidation();

            Console.WriteLine("Hey there!\n\n" +
                "This is just a simple console application.\n" +
                "The goal is to validate your basic user information.\n\n" +
                "Enjoy.\n");

            // Prompt user for inputs
            Console.Write("Username (1-8 alphanumeric characters):");
            user.Username = Console.ReadLine();

            Console.Write("Email:");
            user.Email = Console.ReadLine();

            Console.Write("Password (at least 6 characters with one uppercase letter, one number, and one special character):");
            user.Password = Console.ReadLine();

            Console.Write("Phone Number (10-15 digits):");
            user.PhoneNumber = Console.ReadLine();

            // Initializing validation
            if (validator.ValidateUser(user))
            {
                // Success with a humor :-)
                Console.WriteLine();
                Console.WriteLine("Well done!");
                Console.WriteLine("Sending your personal data to NASA...");
            }
            else
            {
                // Oops! we have a problem :-(
                Console.WriteLine();
                Console.WriteLine("Oops! we have a problem :-(");
                Console.WriteLine();

                if (!validator.ValidateUsername(user.Username))
                    Console.WriteLine("[WARNING] Invalid Username. It should be alphanumeric and 1-8 characters long.");

                if (!validator.ValidateEmail(user.Email))
                    Console.WriteLine("[WARNING] Invalid Email. Please enter a valid email format.");

                if (!validator.ValidatePassword(user.Password))
                    Console.WriteLine("[WARNING] Invalid Password. It should be at least 6 characters, include one uppercase letter, one number, and one special character.");

                if (!validator.ValidatePhoneNumber(user.PhoneNumber))
                    Console.WriteLine("[WARNING] Invalid Phone Number. It should be numeric and 10-15 characters long.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
