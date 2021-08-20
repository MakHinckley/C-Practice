using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    class Program
    {
        //Notes:
        //This is a basic Calculator App 
        // If you try to add two numbers as strings ("43" + "56"), it will concatenate them, giving you "4356", not 99
        //ToInt32 converts the "string" into 32 bits, there's also a 16 and 64
        //Example:
        //int num = Convert.ToInt32("45");  <- converts integer into string. HAS to have a number in it!
        //Console.WriteLine(num + 6); will give you 51!
        //In most cases, double will come in handy and is most often used because of it's ability to handle both whole numbers and decimals
       
        
        
        static void Main(string[] args)
        {

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            // If you try to enter a decimal nunmber, the program doesn't continue. To make this work, use double! For convert, use ToDouble!

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
           
            
            Console.ReadLine();
        }
    }
}
