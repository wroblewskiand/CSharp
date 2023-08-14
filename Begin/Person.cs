using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// /* S3O2
namespace Begin
{
    class Person
    {
        // atrybuty
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        // metody/funkcje
        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }
        
         // public DateTime GetDateOfBirth() { 
         //     return dateOfBirth;
         // }

         public DateTime GetDateOfBirth() => dateOfBirth;

         public void SayHi()
        {
            // Console.WriteLine($"Hi, I'm {this.FirstName}, {this.GetDateOfBirth()}");
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }
    }
}
// */



/* S3O1
namespace Begin
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public DateTime DateOfBirth;
    }
}
// */