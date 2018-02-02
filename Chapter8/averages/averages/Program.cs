using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 24, 2017
///   Purpose: Program that displays the average of all numbers 
///            within an array
///-----------------------------------------------------------------
namespace averages
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbahs = new int[999];
            magic(ref numbahs);
        }
        static void magic(ref int[] numbahs)
        {
            int i = 0, stahp = 0, total = 0;
            string reply;
            WriteLine("Give me a number to add to the array, or type stop to stop.");
            numbahs[0] = Int32.Parse(ReadLine());
            total += numbahs[0];
            while (stahp != 1)
            {
                i += 1;
                WriteLine("Give me a number to add to the array, or type stop to stop.");
                reply = ReadLine();
                if (reply != "stop")
                {
                    numbahs[i] = Int32.Parse(reply);
                    total += Int32.Parse(reply);
                }
                else
                    stahp = 1;
            }
            WriteLine("");
            for (int j = 0; j < i; j++)
                Write(numbahs[j] + " ");
            WriteLine(", and your average is {0}.", total / i);
            ReadLine();
        }
    }
}
