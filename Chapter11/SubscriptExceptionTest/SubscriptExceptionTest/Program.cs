using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 22, 2017
///   Purpose: Program that returns the position of a value within
///            an array and throws an exception if value is not 
///            found
///-----------------------------------------------------------------
namespace SubscriptExceptionTest
{
    class Program
    {
        static void Main()
        {
            Double[] twennyNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            try
            {
                int on = 1;
                int place = 0;
                while (on == 1)
                {
                    WriteLine("Gimme a place number between 1 and 20 within TwennyNum Array ");
                    place =Int32.Parse(ReadLine());
                    WriteLine(place + " value is " + twennyNum[place-1]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
            }
            ReadLine();
        }
    }
}
