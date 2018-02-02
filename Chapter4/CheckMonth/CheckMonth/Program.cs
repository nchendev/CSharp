using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: October 11, 2016
///   Purpose: Program that checks if someone's birth month is valid
///-----------------------------------------------------------------
namespace CheckMonth
{
    class Program
    {
        static void Main()
        {
            double month;
            WriteLine("What is your birth month(in number form)?");
            month = double.Parse(ReadLine());
            if (month >= 1 && month <= 12)
            {
                WriteLine("{0} is a valid month.", month);
            }
            else
            {
                WriteLine("ERROR!");
            }
            ReadLine();
        }
    }
}
