using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConvertQuartsToLiters
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How many quarts?");
            double noQuarts = double.Parse(ReadLine());
            Convert2l(noQuarts);
            ReadLine();
        }
        static void Convert2l(double x)
        {
            WriteLine("{0} is {1} liters.", x, x * .966353);
        }
    }
}
