using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofGuesses = false; 



            while (guess != secretWord && !outofGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outofGuesses = true; 
                }
               

            }
                 if (outofGuesses)
                 {
                    Console.Write("You Lose!");
                 }
                else
                {
                    Console.Write("You Win!");
                }
            



            Console.ReadLine();
        }
    }
}
