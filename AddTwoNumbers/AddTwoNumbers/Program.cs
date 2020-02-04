using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the 1st number
            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Prompt for the 2nd number
            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Calculate the sum
            int sum = firstNumber + secondNumber;

            // Display results
            Console.Write($"The sum is {sum}.");

            // Pause the program
            Console.ReadLine();

        }
    }
}
