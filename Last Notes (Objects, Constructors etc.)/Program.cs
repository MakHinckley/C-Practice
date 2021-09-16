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
            /*Classes and Objects: allow you to create your own custom data types
             * class = specification for a new DT
             * To createa new class, go to solution explorer, right click on project (Last Notes), click add and click on new item. 
             * Select Class and give it a name. (Create classes with a capital letter!!)
             * 
             * Object- instance of a class (creating the physical thing)
             * create as many as you want
             */
           
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception a) //Can also do multiple catch brackets, as well as specify the error
                                //Ex: DivideByZeroException, FormatException 
            {
                Console.WriteLine(a.Message);
            }

            //Classes and Objects Ex:

            ExBook book1 = new ExBook(); //instance of a book
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            ExBook book2 = new ExBook();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.title); //calling the book
            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
