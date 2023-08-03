 /* Do while

using System;
using System.Text;

namespace Begin
{
    class S2O11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To exit, type 'x'");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                int i = 0;
                while (i < userInput.Length)
                {
                    Console.WriteLine($"Echo: {userInput}");
                    i++;
                }
            } while (userInput != "x");
        }   
    }
}

// */