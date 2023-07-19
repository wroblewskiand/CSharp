// Konwersja typów i rzutowanie

// /*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin
{
    internal class S2O8
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();


            // metoda 1
            // int yearOfBirth = int.Parse(userInput);
            // float floatValue = float.Parse(userInput);
            // short shortValue = short.Parse(userInput);
            // int age = DateTime.Now.Year - yearOfBirth;
            // Consol.WriteLine("You are " + age);


            // metoda 2
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine("You are " + age);
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }
        }   
    }
}

// */