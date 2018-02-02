using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-------------------------------------------------------------------
///   Author:  Nick Chen                    Date: November 14, 2016
///   Purpose: Program that returns perfect numbers from user-inputted
///            values
///-------------------------------------------------------------------
namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (double number = 0; number <= 1000; ++number)
            {
                for (int i = 1; i < number; i++)
                {
                    if (Math.Round(number / i) == number / i)
                    {
                        sum = sum + i;
                        if ((number - sum) == 0)
                            WriteLine("{0} is a perfect number", sum);
                    }
                }
                sum = 0;
            }
            ReadLine();


        }
    }
}
