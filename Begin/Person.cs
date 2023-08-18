using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// /* S3O5
namespace Begin
{
    class Person
    {
        private string FirstName;
        private string LastName;

        private DateTime dateOfBirth;
        private string contactNumber;

        public static int Count = 0;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number");
                }
                else
                {
                    contactNumber = value;
                }
            }
        }

        // CONSTRUCTORS
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        // SETS
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
        // GETS
        public DateTime GetDateOfBirth() => dateOfBirth;

        // OTHERS
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }

    }
}


/* S3O4
namespace Begin
{
   class Person
   {
       private string FirstName;
       private string LastName;

       private DateTime dateOfBirth;

       // PROPERTITY 1
       // private string contactNumber;

       // public string ContractNumber{
       //    get { return contactNumber; }
       //    set { contactNumber= = value; }
       // }

       // PROPERTITY 2
       // public string ContractNumber { get; set; }

       // PROPERTITY 3
       private string contactNumber;

       public string ContactNumber
       {
           get { return contactNumber; }
           set
           {
               if (value.Length < 9)
               {
                   Console.WriteLine("Invalid contact number");
               }
               else
               {
                   contactNumber = value;
               }
           }
       }

       // PROPERTITY 2
       // public string ContractNumber { get; set; }



       // CONSTRUCTORS
       public Person(string firstName, string lastName)
       {
           Console.WriteLine("Constructor 1");
           FirstName = firstName;
           LastName = lastName;
       }
       // z wykorzystaniem konstruktora wyżej
       public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
       {
           Console.WriteLine("Constructor 2");
           SetDateOfBirth(dateOfBirth);

       }

       // SETS
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
       // GETS
       public DateTime GetDateOfBirth() => dateOfBirth;

       // OTHERS
       public void SayHi()
       {
           Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
       }

   }
}


/* S3O3
namespace Begin
{
  class Person
  {
      private string FirstName;
      private string LastName;

      private DateTime dateOfBirth;

      // CONSTRUCTORS
      public Person(string firstName, string lastName)
      {
          Console.WriteLine("Constructor 1");
          FirstName = firstName;
          LastName = lastName;
      }
      // VER 2
      // public Person(DateTime dateOfBirth, string firstName, string lastName){
      //    SetDateOfBirth(dateOfBirth);
      //    FirstName = firstName;
      //    LastName = lastName;
      // }

      // VER 2.1 - z wykorzystaniem konstruktora 2.1
      public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
      {
          Console.WriteLine("Constructor 2");
          SetDateOfBirth(dateOfBirth);

      }

      // SETS
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
      // GETS
      public DateTime GetDateOfBirth() => dateOfBirth;

      // OTHERS
      public void SayHi()
      {
          Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
      }

  }
}


/* S3O2
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