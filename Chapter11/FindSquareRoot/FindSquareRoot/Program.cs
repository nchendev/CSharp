using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 24, 2017
///   Purpose: Program that finds the square root of valid numbers
///            and throws an exception when invalid numbers are
///            submitted
///-----------------------------------------------------------------
namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0;
            bool trigger = false;
            while(trigger == false)
            {
                WriteLine("Enter a number you want to be square rooted");
                try
                {
                    num = double.Parse(ReadLine());
                    if (num < 0)
                    {
                        negativeValueException nve = new negativeValueException();
                        throw (nve);
                    }
                }
                catch (negativeValueException n)
                {
                    WriteLine(n.Message);
                    num = 0;
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
                finally
                {
                    WriteLine("Square root = " + Math.Sqrt(num));
                }
                WriteLine("");
                WriteLine("Enter 'end' to end program, or anything else to continue");
                if (ReadLine() == "end")
                    trigger = true;
                WriteLine("");
            }
        }
    }
    class negativeValueException:Exception
    {
        private static string msg = "Input value was negative.";
        public negativeValueException():base(msg)
        { }
    }
}
