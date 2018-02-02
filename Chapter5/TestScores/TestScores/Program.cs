using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: November 4, 2016
///   Purpose: Program that returns the number of test scores the
///            user submits and the average score
///-----------------------------------------------------------------
namespace TestScores
{
    class Program
    {
        static void Main()
        {
            int total = 0, numsub = 0, current = 0;
            WriteLine("WHATS YOUR TEST SCORE?");
            current = int.Parse(ReadLine());
            while (current != 100)
            {
                if (current <= 100 && current >= 1)
                {
                    WriteLine("WHATS YOUR TEST SCORE?");
                    current = int.Parse(ReadLine());
                    total = total + current;
                    numsub = numsub + 1;
                }
                else
                {
                    WriteLine("ERROR MESSAGE");
                    WriteLine("WHATS YOUR TEST SCORE?");
                    current = int.Parse(ReadLine());
                    total = total + current;
                    numsub = numsub + 1;
                }
            }
            WriteLine("You entered {0} scores with an average of {1}", numsub, total / numsub);
            ReadLine();
        }
    }
}
