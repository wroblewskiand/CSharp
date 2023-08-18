 /* Class PROPERTIES

using System;
using System.Text;
using System.Threading.Channels;

namespace Begin
{
    class S3O4
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            bill.SayHi();
            bill.ContractNumber = "999888777";

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");

            john.SayHi();

        }
    }
}

// */
