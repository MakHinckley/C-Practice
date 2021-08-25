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
        // Switch Statements= special kind of if statement where you can check a ton of different statements easily


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

            Console.WriteLine(GetMax(20, 10, 40)); // Comparison EX

            Console.WriteLine(GetDay(4)); // Switch Statement EX:



            //WHILE LOOPS
            //Same concept as if statements
            //Keeps going until the condition is FALSE, keeps looping through the same stuff. (similar to Python)
            //works only if the condition is TRUE

            int index = 1;  //Creates the variable (AKA prints it) Then it checks the condition
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;    //What this is saying is that if index is less than or equal to 5, add 1 interger to index. When it reaches or is eaqu to 5, than the loop stops.
            }

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

        //SWITCH STATEMENTS
        //Switch parameter needs a value
        //Anything you can do in a switch statement, you can do in a if statement. Just makes it easier/ less messier.
        //break is a reserved word that we use to "break" out of the current case, if no break, it will keep checking the same case over and over.
        //case is essentially a value that is checked.
        //The default statement is executed if no case constant-expression value is equal to the value of expression
        static string GetDay(int dayNum)
        {

            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;     
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
       
    }
}
