using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, Alan");

            string userName;
            string userName2 = "Software";

            // Prompt the user
            Console.Write("What is your name?");

            // Accept the user input
            userName = Console.ReadLine();


            // To display Hello, <userName>!
            //Console.Write("Hello, " + userName + "!");

            // Another way of concatenating strings
            //Console.Write("Hello, {0}!", userName);

            // The neatest of concatenating strings using
            // string interpolation
            Console.Write($"Hello, {userName} {userName2}!");


            // To pause the program
            Console.ReadLine();
        }
    }
}
