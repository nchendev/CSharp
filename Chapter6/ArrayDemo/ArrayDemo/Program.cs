using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///------------------------------------------------------------------
///   Author:  Nick Chen                    Date: November 30 2016
///   Purpose: Program that gives the user options to view the
///            contents of an array either first to last or backwards
///------------------------------------------------------------------
namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            int start = 0, end = 0, answer = 1;
            double[] values = { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i <= 7; i++)
            {
                WriteLine("Input a number");
                values[i] = double.Parse(ReadLine());
            }
            WriteLine("Enter 1 to view the list in order from first to last position. Enter 2 to view the list backwards, enter 3 to view the list in a specific position. Enter anything else to quit.");
            answer = Int32.Parse(ReadLine());
            while (answer == 1 || answer == 2 || answer == 3)
            {
                if (answer == 1)
                {
                    for (int i = 0; i <= (values.Length - 1); i++)
                    {
                        WriteLine(values[i]);
                    }
                    WriteLine("Enter 1 to view the list in order from first to last position. Enter 2 to view the list backwards, enter 3 to view the list in a specific position. Enter anything else to quit.");
                    answer = Int32.Parse(ReadLine());
                }
                if (answer == 2)
                {
                    Array.Reverse(values);
                    for (int i = 0; i <= (values.Length - 1); i++)
                    {
                        WriteLine(values[i]);
                    }
                    WriteLine("Enter 1 to view the list in order from first to last position. Enter 2 to view the list backwards, enter 3 to view the list in a specific position. Enter anything else to quit.");
                    answer = Int32.Parse(ReadLine());
                }
                if (answer == 3)
                {
                    WriteLine("Insert the starting position you want");
                    start = Int32.Parse(ReadLine());
                    WriteLine("Insert the ending position you want");
                    end = Int32.Parse(ReadLine());
                    for (int i = start; i <= end; i++)
                        WriteLine(values[i]);
                    WriteLine("Enter 1 to view the list in order from first to last position. Enter 2 to view the list backwards, enter 3 to view the list in a specific position. Enter anything else to quit.");
                    answer = Int32.Parse(ReadLine());
                }
            }
        }
    }
}