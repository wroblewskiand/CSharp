/*Zadanie:

Utwórz aplikację konsolową, która będzie wczytywać wartości liczbowe od użytkownika, dopóki nie poda on wartości 0.

Podczas czytania, aplikacja powinna:

- obliczyć sumę wszystkich elementów
- znaleźć największy element

Po wczytaniu wartości 0, te dwie wartości powinny zostać wypisane w konsoli.
*/

// /* zadanie

using System;
using System.Text;

namespace Begin
{
    class S2O13zadanieV1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers:");

            int userInput = int.Parse(Console.ReadLine());

            int sum = 0;
            int? max = null;

            while (userInput != 0)
            {
                if (max == null || userInput > max)
                {
                    max = userInput;
                }
                sum += userInput;

                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of numbers = {sum}");

            if (max != null)
            {
                Console.WriteLine($"Max of numbers = {max}");
            }
            else
            {
                Console.WriteLine("No values inserted");
            }
        }   
    }
}

// */