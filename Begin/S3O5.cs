 /* Class PROPERTIES

using System;
using System.Text;
using System.Threading.Channels;

namespace Begin
{
    class S3O5
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            bill.SayHi();
            bill.ContactNumber = "999888777";

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");

            john.SayHi();


            Console.WriteLine($"Objects of Person type count: {Person.Count}");

            // inne elementy static
            // static method from Console
            // Console.WriteLine();
            // Console.ReadLine();

            // static property from DateTime
            // DateTime.NOW

            // static method from int
            // int.Parse();


        }
    }
}

// */
