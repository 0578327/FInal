using System;

namespace FinalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Age Calculator App!");
            Console.Write("Please enter your birthday (MM/DD/YYYY): ");
            string? input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthday))
            {
                TimeSpan ageInDays = DateTime.Now - birthday;
                Console.WriteLine($"Your age in days is: {ageInDays.TotalDays:N0}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter your birthday in MM/DD/YYYY format.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}