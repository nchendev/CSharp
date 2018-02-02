using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: December 5 2016
///   Purpose: Program that calculates a cell phone bill based on
///            time spent on phone and zip code
///-----------------------------------------------------------------
namespace ChatAWhile
{
    class Program
    {
        static void Main()
        {
            bool service = false;
            int[,] aCR = { { 73012, 4 }, { 73013, 5 }, { 73014, 6 }, { 73015, 7 }, { 73016, 8 }, { 73017, 9 } };
            WriteLine("What is your Zip Code?");
            int myZip = Int32.Parse(ReadLine());
            for (int i = 0; i <= 6; i++)
            {
                if (myZip == aCR[i, 0])
                {
                    service = true;
                    WriteLine("How many minutes were you on the phone?");
                    int time = Int32.Parse(ReadLine());
                    WriteLine("Your Bill is " + aCR[i, 1] * time + " dollars");
                    ReadLine();
                }
            }
            if (service == false)
            {
                WriteLine("I'm sorry, but we don't deliver to your zip code.");
                ReadLine();
            }
        }
    }
}
