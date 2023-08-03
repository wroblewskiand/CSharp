/*Zadanie:

Utwórz aplikację konsolową, która będzie wczytywać wartości liczbowe od użytkownika, dopóki nie poda on wartości 0.

Podczas czytania, aplikacja powinna:

- obliczyć sumę wszystkich elementów
- znaleźć największy element

Po wczytaniu wartości 0, te dwie wartości powinny zostać wypisane w konsoli.
*/

/* zadanie

using System;
using System.Text;
using System.Threading.Channels;

namespace Begin
{
   class S2O13zadanieV0
   {
       static void Main(string[] args)
       {
            Console.WriteLine("Insert numbers:");

            int sum = 0;
            int max = 0;
            int userInput = int.Parse(Console.ReadLine());
           
            do
            {
                sum += userInput;
                if (userInput > max) max = userInput;
                userInput = int.Parse(Console.ReadLine()) ;

            } while (userInput != 0);

           Console.WriteLine($"Sum of numbers = {sum}");
           Console.WriteLine($"Max of numbers = {max}");
       }   
   }
}

// */