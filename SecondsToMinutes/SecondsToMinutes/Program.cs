using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the time in seconds
            Console.Write("Please enter the time in seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            // Convert to minutes
            double minutes = seconds / 60.0;

            // Display the results
            Console.WriteLine($"The answer is {minutes} minutes.");

            // Pause the program
            Console.ReadLine();

        }
    }
}
