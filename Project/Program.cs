using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    //Notes 

    //class= an area or container to store code (hold methods, or in this example, out Main)
    //the method (static void Main) is where we will actually write and execute the code!
    //Whenever you write a line in C#, ALWAYS end the line with a ';'
    //The order in which you write your code MATTERS! 
    //DT 'char' or charcter can only have 1 letter and NEEDS to be in single quotes ''
    //Numbers DT 'int' can handle whole numbers as well as negatives. They DON'T need quotes around them
    //Float, Double and Decimal can all handle non-whole numbers. Floats are the least specific version, Doubles are a good in-between ground, and Decimals are used for highly specific cases (such as money)

    class Program
    {
        static void Main(string[] args)
        {
            // Beginning of Variables and concatenating 
            string characterName = "Tom";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            
            characterName = "Mike"; //Switching it up! Same variable, different argument
            
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But he didn't like being " + characterAge);

            //Building a Shape

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            //Data Types 
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            //Strings Practice 

            Console.WriteLine("Hello World!");
            Console.WriteLine("Coding\nDojo");
            Console.WriteLine("Here is\" Mak!");  //<- Delineating a String (actually prints one quote mark)
            Console.WriteLine(phrase);
            

            // Finding information aka Methods!
            Console.WriteLine(phrase.ToUpper()); // Converts the phrase to all uppercase
            Console.WriteLine(phrase.ToLower()); // Converts the phrase to all lowercase 
            Console.WriteLine(phrase.Length); //how many characters are in the variable
            Console.WriteLine(phrase.Contains("Academy")); //REturns T or F statement. We are putting a parameter inside of Contains's parenthsis 
            Console.WriteLine(phrase[0]); // Think of Python dictionary positions. So what is the charcter in phrase at position 0? G!
            Console.WriteLine(phrase.IndexOf("Academy")); // Finds where certain data bits start at. 8. Can also put in characters!
            Console.WriteLine(phrase.IndexOf('A'));
            Console.WriteLine(phrase.Substring(6)); // Allows you to grab one part of the phrase starting at the position and going to the end of the called variable
            Console.WriteLine(phrase.Substring(8, 3)); //Can pass in a link (put in a , to seperate) to grab x amount of characters. EX: Starting at position 8 and grabbing 3 characters (should get 'Aca')

            Console.ReadLine();
         
        }
      
    }
    
}
