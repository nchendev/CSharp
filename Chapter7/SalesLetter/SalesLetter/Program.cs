using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 9, 2017
///   Purpose: Program that displays a sales letter
///-----------------------------------------------------------------
namespace SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Hello! I'm representing Real Egg Rolls!");
            DisplayContactInfo();
            WriteLine("We are here advertise the fact that we have free egg roll tuesdays!");
            WriteLine("Just send us an email or call us- whenever!");
            DisplayContactInfo();
            WriteLine("Don't forget! Again, here it is!");
            DisplayContactInfo();
            WriteLine("Thank you very much!");
            ReadLine();
        }
        static void DisplayContactInfo()
        {
            WriteLine("(land line number: 405-222-3333");
            WriteLine(" telephone number: 405-222-2323");
            WriteLine(" email: nick.chen053100@gmail.com)");
        }
    }
}
