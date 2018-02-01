using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
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
            WriteLine("What is the last integer?");
            int lastInt = Int32.Parse(ReadLine());

            WriteLine("{0} {1} {2} {3}", firstInt, secondInt, thirdInt, lastInt);

            Reversal(ref firstInt, ref secondInt, ref thirdInt, ref lastInt);

            WriteLine("{0} {1} {2} {3}", firstInt, secondInt, thirdInt, lastInt);

            ReadLine();
        }
        static void Reversal(ref int firstInt, ref int secondInt, ref int thirdInt, ref int lastInt)
        {
            int no1 = firstInt;
            int no2 = secondInt;
            int no3 = thirdInt;
            int no4 = lastInt;

            firstInt = no4;
            secondInt = no3;
            thirdInt = no2;
            lastInt = no1;
        }
    }
}
