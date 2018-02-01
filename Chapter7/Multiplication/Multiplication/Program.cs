using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Gimme an integer:");
            DisplayMultiplicationTable(double.Parse(ReadLine()));
            ReadLine();
        }
        static void DisplayMultiplicationTable(double x)
        {
            for (int i=2; i<=10; i++)
            {
                WriteLine("{0} times {1} is {2}.", x, i, x*i);
            }
        }
    }
}
