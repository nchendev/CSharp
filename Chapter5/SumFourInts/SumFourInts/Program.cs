using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: November 4, 2016
///   Purpose: Program that sums four integers
///-----------------------------------------------------------------
namespace SumFourInts
{
    class Program
    {
        static void Main()
        {
            int x = 1, sum = 0;
            while (x <= 4)
            {
                WriteLine("Give me an integer");
                sum = sum + int.Parse(ReadLine());
                x = x + 1;
            }
            WriteLine("The sum of the 4 integers is {0}", sum);
            ReadLine();
        }
    }
}
