using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: October 17, 2016
///   Purpose: Program that simulates a lottery
///-----------------------------------------------------------------
namespace Lottery
{
    class Program
    {
        static void Main()
        {
            //Variables
            double guess1, guess2, guess3, matching = 0, amtWon = 0;
            /*Random ranNumberGenerator1 = new Random();
            int randomNumber1 = ranNumberGenerator1.Next(1, 4);
            Random ranNumberGenerator2 = new Random();
            int randomNumber2 = ranNumberGenerator2.Next(1, 4);
            Random ranNumberGenerator3 = new Random();
            int randomNumber3 = ranNumberGenerator3.Next(1, 4);*/

            //Code to test whether lottery is working
            int randomNumber1 = 1;
            int randomNumber2 = 2;
            int randomNumber3 = 3;

            //Choosing numbers
            WriteLine("Alright! Lets play the lottery! The amount you'll win depends on both the numbers you choose and the order you choose them in! Choices are 1-4, and is repeatable");
            WriteLine("First Guess:");
            guess1 = double.Parse(ReadLine());
            WriteLine("Second Guess:");
            guess2 = double.Parse(ReadLine());
            WriteLine("Third Guess:");
            guess3 = double.Parse(ReadLine());
            //calculations
            if (guess1 == randomNumber1 || guess1 == randomNumber2 || guess1 == randomNumber3)
            {
                matching = ++matching;
            }
            if (guess2 == randomNumber1 || guess2 == randomNumber2 || guess2 == randomNumber3)
            {
                matching = ++matching;
            }
            if (guess3 == randomNumber1 || guess3 == randomNumber2 || guess3 == randomNumber3)
            {
                matching = ++matching;
            }
            //less than 3 matching
            if (matching != 3)
            {
                amtWon = Math.Pow(10, matching);
                if (amtWon == 1)
                {
                    amtWon = 0;
                }
            }
            //3 matching, in order
            if ((matching == 3))
            {
                //3 matching, in order
                if (guess1 == randomNumber1 && guess2 == randomNumber2 && guess3 == randomNumber3)
                {
                    amtWon = 10000;
                }
                else
                //3 matching, not in order
                if (guess1 == randomNumber1 || guess1 == randomNumber2 || guess1 == randomNumber3 && guess2 == randomNumber1 || guess2 == randomNumber2 || guess2 == randomNumber3 && guess3 == randomNumber1 || guess3 == randomNumber2 || guess3 == randomNumber3)
                {
                    amtWon = 1000;
                }
            }

            //Final WriteLine
            WriteLine("Your winnings is {0}!", amtWon);

            ReadLine();
        }
    }
}
