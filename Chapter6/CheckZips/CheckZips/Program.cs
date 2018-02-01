using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZips
{
    class Program
    {
        static void Main()
        {
            int[] zipCodes = {73012, 73013, 73014, 73015, 73016, 73017, 73018, 73019, 73020, 73021, 73022, 73023 };
            int i = 0, myZip = 0;
            bool deliver = false;
            WriteLine("What is your zip code?");
            myZip = Int32.Parse(ReadLine());
            for (i = 0; i <= 10; i++)
            {
                if (zipCodes[i] == myZip)
                {
                    WriteLine("We deliver to your zip code.");
                    deliver = true;
                    ReadLine();
                }
                else
                    deliver = false;
            }
            if (deliver == false)
            {
                WriteLine("I'm sorry but we don't deliver to your zip code.");
            }
            ReadLine();
        }
    }
}
