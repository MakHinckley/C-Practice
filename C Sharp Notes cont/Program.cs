using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Notes_cont
{
    class Program
    {
        // Notes:
        //return statements = returning information back to the callers
        //If statements:
        //need a condition and a action that's executed when it's true. (only two possible values)
        //create a variable for if statements to create a basis for what is true or false.
        // && (and) let's you use two conditions in the same condition block (are they male and tall?) 
        //BOTH conditions have to agree, if they dont, they will print the else statement
        //EX: if a person is both female and tall, then the first condition will be printed. If not, then the second statement will be printed.
        // || (or) allows there to be only one true condition
        //EX: if you are a male, but you are tall, the first condition will be ran; same if you were to flip the scenario. IF both are false, then the second condition will run instead.
        // ! (negation operator) same as python
        // inside of if statements, you can have comparisons (that compare tw values) 



        static void Main(string[] args)
        {
            //Return Statements -> creating a cubed power app. Keywords
            
            int cubedNumber = Cube(5);
            Cube(5);
            //But it doesn't work, Why?? It did return a value, but it needed to be printed in order to be viewed!
            
            Console.WriteLine(Cube(5));
            //can also set it as a variable, put the calling method inside the variable and it'll stay the same!
           
            Console.WriteLine(cubedNumber);

            //If statements:
            bool isFemale = false;
            bool isTall = false;

            //AND

            if (isFemale && isTall) //<- ONLY gets executed if condition (variable) is TRUE. If you set isFemale to false, it will not execute.
            {
                Console.WriteLine("You are a tall female!");
            }
            else
            {
                Console.WriteLine("You are either not a female, tall or both");
            }

            //OR

            if (isFemale || isTall) //<- ONLY gets executed if condition (variable) is TRUE. If you set isFemale to false, it will not execute.
            {
                Console.WriteLine("Great work! One or more of the conditions has been met!");
            }
            else
            {
                Console.WriteLine("Both are false! :(");
            }

            //ELSE IF
            
            if (isFemale && isTall) //<- ONLY gets executed if condition (variable) is TRUE. If you set isFemale to false, it will not execute.
            {
                Console.WriteLine("Great work! One or more of the conditions has been met!");
            }
            else if (isFemale && !isTall)
            {
                Console.WriteLine("You are a short female!");
            }
            else if (!isFemale && isTall)
            {
                Console.Write("You are not a female, but you are tall!");
            }
            else
            {
                Console.WriteLine("Both are false! :(");
            }

            Console.WriteLine(GetMax(20, 10, 40));
            Console.ReadLine();
        }

        static int Cube(int num) // <- you can return anything! Strings, ints, doubles, arrays etc. 
        {
            int result = num * num * num;
            return result;
        }


        //Comparisons EX: 
        static int GetMax(int num1, int num2, int num3) // THE MAX METHOD= taking in two or more parameters and telling us which one is higher
        {
            int result;

            if (num1 >= num2 && num1 > num3)
            {
                result = num1;

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }


    }
}
