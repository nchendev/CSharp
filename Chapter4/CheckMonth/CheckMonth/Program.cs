using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckMonth
{
    class Program
    {
        static void Main()
        {
            double month;
            WriteLine("What is your birth month(in number form)?");
            month = double.Parse(ReadLine());
            if (month >= 1 && month <= 12)
            {
                WriteLine("{0} is a valid month.", month);
            }
            else
            {
                WriteLine("ERROR!");
            }
            ReadLine();
        }
    }
}
