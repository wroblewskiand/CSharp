/* Class metody

using System;
using System.Text;
using System.Threading.Channels;

namespace Begin
{
    class S3O2
    {
        static void Main(string[] args)
        {
            Person bill = new Person();

            bill.FirstName = "Bill";
            bill.LastName = "Cossby";
            bill.SetDateOfBirth(new DateTime(2010, 11, 12));

            // Console.WriteLine($"Now it time: {DateTime.Now}");
            // Console.WriteLine($"{bill.FirstName} - {bill.GetDateOfBirth()}");
            bill.SayHi();
        }
    }
}

// */
