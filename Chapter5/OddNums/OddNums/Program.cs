using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: November 8, 2016
///   Purpose: Program that returns odd numbers from user-inputted
///            values
///-----------------------------------------------------------------
namespace OddNums
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            while (number != 99)
            {
                number += 1;
                if ((number % 2) == 1)
                {
                    WriteLine("{0}", number);
                }
            }
            ReadLine();
        }
    }
}
