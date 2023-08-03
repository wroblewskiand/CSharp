/* While

using System;
using System.Text;

namespace Begin
{
    internal class S2O10
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW" , "Mazda" };

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }
        }   
    }
}

*/     