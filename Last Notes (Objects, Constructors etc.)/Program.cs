using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Notes__Objects__Constructors_etc._
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exception Handling
               But what can we do to avoid throwing an error? 
               Use try and catch brackets to put the code inside, if there's an error, 
                    the catch will throw the exception message before the program terminates.
                Can also do multiple catch brackets, as well as specify the error
                    Ex: DivideByZeroException, FormatException 
                    -this is the better way to do exception handling 
                finally brackets will always be executed no matter what
            */

            try
            {
                Console.Write("Enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception a) //Can also do multiple catch brackets, as well as specify the error
                                //Ex: DivideByZeroException, FormatException 
            {
                Console.WriteLine(a.Message);
            }
            
            
        }
    }
}
