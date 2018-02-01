using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            while (number != 99)
            {
                number += 1;
                if ((number % 2) == 1)
                {
                    WriteLine("{0}", number);
                }
            }
            ReadLine();
        }
    }
}
