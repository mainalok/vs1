/*
 1st tutorial code here
- This will be C# console app 
- When you set this project it creates many files 
- Ujsing .net8 
 */

// Importing - Name space which has important classes and functions 
// If you dont have this then you woul type
// System.Console.Writeln() , but if you import it then it becomes easier like, 
// Import panty as P - similar in python

using System;

// Writing a command to display stuff on the console

// App being defined here 
namespace ConsoleApp1
{   // This is the main function name panty 
    public class Panty
    {   //  No need to create object , void means no return value after exiting
        // Note semicolon is important at end of every statement
        static void Main(string[] args)
        {
            Console.Clear(); // Clearing screen before starting
            
            // Checing various console methods - note when changing colors you have to first change 
            // Then do the console printing
            Console.ForegroundColor = ConsoleColor.Green;

            // Text to write
            Console.WriteLine("Hello Fucker Bastard");
            Console.WriteLine("--------------------");

            // Getting an input from the user 
            Console.Write("What dirty fetish you want ?");

            // Accepting the user input 
            string name = Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine($"Rapist wants : {name}");


        }
    }
}