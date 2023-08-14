/* Nullable

using System;
using System.Text;

namespace Begin
{
    class S2O15
    {
        static void Main(string[] args)
        {
            // VER1
            // int favoriteNumber;
            // bool favoriteNumberHasValue = false;
            //Console.WriteLine("Favorite number " + (favoriteNumberHasValue ? favoriteNumber.ToString() : ""));
            
            // VER 2
            //Nullable<int> favoriteNumber;
            
            // VER 3
            int? favoriteNumber = 22;
            //Console.WriteLine("Favorite number " + (favoriteNumber =! null ? favoriteNumber.ToString() : ""));
            Console.WriteLine("Favorite number " + (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));

        }
    }
}

//  */