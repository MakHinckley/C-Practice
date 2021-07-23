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
    //When you have two integers and the result is acutally a decimal, it will print out a Integer, hwne you have one integer and a decimal, it will print a decimal
    //When you have to decimals togehter, you will always get a decimal back 
    // Method= a block of code that performs a certain task, you call methods that can be used with data types
    // Array= container that can hold many different values 



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


            // Finding information/Methods!
            Console.WriteLine(phrase.ToUpper()); // Converts the phrase to all uppercase
            Console.WriteLine(phrase.ToLower()); // Converts the phrase to all lowercase 
            Console.WriteLine(phrase.Length); //how many characters are in the variable
            Console.WriteLine(phrase.Contains("Academy")); //REturns T or F statement. We are putting a parameter inside of Contains's parenthsis 
            Console.WriteLine(phrase[0]); // Think of Python dictionary positions. So what is the charcter in phrase at position 0? G!
            Console.WriteLine(phrase.IndexOf("Academy")); // Finds where certain data bits start at. 8. Can also put in characters!
            Console.WriteLine(phrase.IndexOf('A'));
            Console.WriteLine(phrase.Substring(6)); // Allows you to grab one part of the phrase starting at the position and going to the end of the called variable
            Console.WriteLine(phrase.Substring(8, 3)); //Can pass in a link (put in a , to seperate) to grab x amount of characters. EX: Starting at position 8 and grabbing 3 characters (should get 'Aca')

            //Numbers and Ops
            //There's whole numbers and decimal numbers and does distinguish between the two
            //Can write simple math operations (addition, subtraction etc.) as well as order of operations in the parenthesis 
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 % 2); //<- Modulus (%) Opertator 
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(4 + 3 * 10);
            Console.WriteLine(3.0 + 6.5);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(2.0 + 3);

            // Shorthand ++ and -- subtract or add 1 to the num variable (6)
            int num = 6;
            num++;
            Console.WriteLine(num);

            //Methods for numbers (Math.)((to start it)
            Console.WriteLine(Math.Abs(-40)); // Absolute Value: 40
            Console.WriteLine(Math.Pow(3, 2)); //Power: 3 to the power of 2
            Console.WriteLine(Math.Sqrt(36)); //Square Root: 6
            Console.WriteLine(Math.Max(4, 90)); // Max will give you the biggest number
            Console.WriteLine(Math.Min(3, 2)); //Minumum will give you the smallest number
            Console.WriteLine(Math.Round(4.3)); // Rounds number accorgin to standard rounding rules

            //User Inputs
            //ReadLine pauses the execution of code(program) (the window we see), but it's also waiting for user inputs (a line of text)
            // The difference between Write and Writeline is that Wrtieline stays to one line and then goes to another. Write keeps it all together. Write allows us to write in the exe without it closing
            //store the name in a variable and is printed out on the next line

            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //Console.Write("Enter your age:");
            //string Makage = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " you are " + Makage);

            //Arrays 

            int[] luckyNumbers = { 4,8,15,16,28,23,42 }; // each number insdie curly bracket is an element 
            string[] friends = new string[10]; // another way to populate a array, or your not sure on what elements are going to go in the array. Still need to put a number in bracket! Will tell C# how many elements to hold
            friends[0] = "Chris"; // assigning string "Chris" to position 0 in the firends array (a way to add information to the array)
            friends[1] = "Alex"; // same as above, but at postion 1. 
            
            Console.WriteLine(luckyNumbers[0]); // will access position 0 (4)
            
            luckyNumbers[1] = 900; // changing a element 
            Console.WriteLine(luckyNumbers[1]);





            Console.ReadLine();

        }
    }

}
