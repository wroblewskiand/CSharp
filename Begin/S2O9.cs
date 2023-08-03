/* Tablice

using System;
using System.Text;

namespace Begin
{
    internal class S2O9
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW" , "Mazda" };
            Console.WriteLine(cars[0]);
            int arrayLenght = cars.Length;  // 3

            cars[2] = "Tesla";

            //    Console.WriteLine(cars[cars.Lenght]);     // out of range
            Console.WriteLine(cars[cars.Length - 1]);	// last argument in the array

        }   
    }
}

*/