using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///------------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 19, 2017
///   Purpose: Program that returns 3 integers forwards and backwards
///------------------------------------------------------------------
namespace Reverse3
{
    class Program
    {
        static void Main()
        {
            WriteLine("What is the first integer?");
            int firstInt = Int32.Parse(ReadLine());
            WriteLine("What is the second integer?");
            int secondInt = Int32.Parse(ReadLine());
            WriteLine("What is the third integer?");
            int thirdInt = Int32.Parse(ReadLine());

            WriteLine("{0} {1} {2}", firstInt, secondInt, thirdInt);

            Reversal(ref firstInt, ref thirdInt);

            WriteLine("{0} {1} {2}", firstInt, secondInt, thirdInt);

            ReadLine();
        }
        static void Reversal(ref int firstInt, ref int thirdInt)
        {
            int no1 = firstInt;
            int no2 = thirdInt;

            firstInt = no2;
            thirdInt = no1;
        }
    }
}
