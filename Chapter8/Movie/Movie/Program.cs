using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 24, 2017
///   Purpose: Program that returns a movies name and length
///-----------------------------------------------------------------
namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is the name of the movie?");
            String name = ReadLine();
            movieNInt(name);
            WriteLine("How long is the movie?");
            int minutes = Int32.Parse(ReadLine());
            movieNInt(name, minutes);
            ReadLine();
        }
        static void movieNInt(string name, int minutes = 90)
        {
            WriteLine("The movie, {0}, is {1} minutes long.", name, minutes);
        }
    }
}
