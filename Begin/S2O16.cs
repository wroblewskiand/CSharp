 /* Try Catch Finally

using System;
using System.Text;

namespace Begin
{
    class S2O16
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Volvo", "Mazda" };

            try
            {
                Console.WriteLine("Inside try - 1");
                cars[3] = "Tesla";
                Console.WriteLine("Inside try - 2");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handling IndexOutOfRangeException exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("Outside of try-catch");
        }
    }
}

// */