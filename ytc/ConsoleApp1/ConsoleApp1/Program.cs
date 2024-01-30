/*
 Code which you are writing from youtube tutorial
- C# Full Course : C# Tutorial for beginners using visual studio
code 
- Making some changes to add to the github again and again 
- Adding a new number to be identifiable 6969 
 */

using System; //Name Space 

// Program starts with a namespace
namespace ConsoleApp1
{
    public class Program
    { 
        // Main function declaration - args to pass args 
        static void Main(string[] args) 
        {

            // This is for he color 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        
            Console.WriteLine("Sucking and fucking");

            // This for accepting user input 
            Console.Write("Bastard what fuck you want ? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Fucker {name}"); // Note this is liek an f string in python
        }
    
    }

}



