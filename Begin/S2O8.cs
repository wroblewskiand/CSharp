// Konwersja typów i rzutowanie

/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Begin
{
    internal class S2O8
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter \"byte value\":");
            //    string stringValue = Console.ReadLine();
            //    int intValue = int.Parse(stringValue);
            //    byte byteValue = (byte) intValue;
            //    Console.WriteLine(byteValue);
            //    if (byte.TryParse(stringValue, out byteValue))
            //    {
            //        //int intValue = byteValue;
            //        byte byteValue2 = (byte)intValue;
            //        // byte byteValue2 = intValue;      // nie można niejawnie (implicity) rzutować int na byte
            //        Console.WriteLine(byteValue);
            //        Console.WriteLine(intValue);
            //        Console.WriteLine(byteValue2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("out of range");
            //    }
            // float floatValue = float.Parse(userInput);       // parsowanie/rzutowanie na inny typ -> float 

            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;

            string stringValue2 = intValue.ToString();

            Console.WriteLine(stringValue2);
             
            Console.WriteLine("Write year of yours birth:");
            string userInput = Console.ReadLine();
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

*/