 /* Enum

using System;
using System.Text;

namespace Begin
{
    class S2O14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender? 1 = Male, 2 = Female");
            string userInput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Only woman are allowed");
            }
            else
            {
                Console.WriteLine("Hi!");
            }
        }
    }
}

//  */