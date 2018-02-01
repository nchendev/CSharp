using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            string choose;
            Random cpu = new Random();
            int randomNumber = cpu.Next(1, 3);
            WriteLine("Lets play rock paper scissors! Input r for rock, p for paper, and s for scissors!");
            choose = ReadLine();
            if (choose == "r")
            {
                if (randomNumber == 1)
                {
                    WriteLine("You tie!");
                }
                if (randomNumber == 2)
                {
                    WriteLine("You Lose!");
                }
                if (randomNumber == 3)
                {
                    WriteLine("You win!");
                }

            }
            if (choose == "p")
            {
                if (randomNumber == 1)
                {
                    WriteLine("You win!");
                }
                if (randomNumber == 2)
                {
                    WriteLine("You tie!");
                }
                if (randomNumber == 3)
                {
                    WriteLine("You lose!");
                }
            }
            if (choose == "s")
            {
                if (randomNumber == 1)
                {
                    WriteLine("You lose!");
                }
                if (randomNumber == 2)
                {
                    WriteLine("You win!");
                }
                if (randomNumber == 3)
                {
                    WriteLine("You tie!");
                }
            }
            ReadLine();
        }
    }
}
