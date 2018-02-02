using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: December 15, 2016
///   Purpose: Program that simulates hangman; user is asked to 
///            guess a word. If he guesses a letter correctly it is
///            shown in the string of asterisks
///            IE: f*r*t (word is first)
///-----------------------------------------------------------------
namespace GuessAWord
{
    class Program
    {
        static void Main()
        {
            //storing 8 words into array
            String[] wordBank = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth" };
            //randomly select one to be hidden word
            Random rnd = new Random();
            int key = rnd.Next(1, 8);
            String word = wordBank[key];
            //use asterisks to represent the hidden letters
            String[] current = new String[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                current[i] = "*";
            }
            //the actual guessing game
            String answer = "-";
            int initial = 0;
            int matchingCD = current.Length;
            while (matchingCD != 1)
            {
                //executes first time around
                while (initial == 0)
                {
                    WriteLine("Welcome to Guess a Word! Guess a letter!");
                    answer = ReadLine();
                    answer.ToLower();
                    initial = 1;
                }
                //all other guesses
                //check if matching and updates current
                int match = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (answer == word.Substring(i, 1))
                    {
                        current[i] = answer;
                        matchingCD -= 1;
                        match = 1;
                    }
                }
                if (match == 1)
                    WriteLine("Yes! {0} is in the word!", answer);
                else
                    WriteLine("No, [0] is not in the word.", answer);
                //writes out current guess
                Write("Your current guess is: ");
                for (int z = 0; z < current.Length; z++)
                {
                    Write(current[z]);
                }
                WriteLine("");
                //Asks for another guess
                Write("Guess another letter: ");
                answer = ReadLine();
                answer.ToLower();
            }
            //congratulates on win
            WriteLine("Congratulations! You win!");
            ReadLine();
        }
    }
}