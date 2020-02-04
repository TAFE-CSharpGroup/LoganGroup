using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the 1st number
            Console.Write("Please enter the second number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Prompt for the 2nd number
            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Prompt for the 3rd number
            Console.Write("Please enter the second number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            // Prompt for the 4th number
            Console.Write("Please enter the second number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            // Calculate the average
            int average = (firstNumber + secondNumber + 
                           thirdNumber + fourthNumber) / 4;

            // For more acurate results
            double average2 = (firstNumber + secondNumber +
                           thirdNumber + fourthNumber) / 4.0;

            // Display results
            Console.WriteLine($"The average is {average}.");
            Console.Write($"The average with decimals is {average2}.");

            // Pause the program
            Console.ReadLine();
        }
    }
}
