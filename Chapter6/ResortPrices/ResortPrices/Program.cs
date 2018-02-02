using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: December 7 2016
///   Purpose: Program that calculates the costs of staying at a 
///            hotel
///-----------------------------------------------------------------
namespace ResortPrices
{
    class Program
    {
        static void Main()
        {
            int[,] pPN = { { 1, 200 }, { 2, 200 }, { 3, 180 }, { 4, 180 }, { 5, 160 }, { 6, 160 }, { 7, 160 }, { 8, 145 } };
            WriteLine("How many nights will you stay at Carefree Hotel?");
            int nights = Int32.Parse(ReadLine());
            int max = 0;
            for (int i = 0; i <= 7; i++)
            {
                if (i == nights)
                {
                    WriteLine("It will be " + pPN[i, 1] * nights + " for " + nights + " nights.");
                    max = 1;
                }
            }
            if (max == 0)
                WriteLine("It will be " + 145 * nights + " for " + nights + " nights.");
            ReadLine();
        }
    }
}
