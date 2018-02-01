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
            int[ , ] zipCodes = { { 73012, 12 }, { 73013, 13 }, { 73014, 14 }, { 73015, 15 }, { 73016, 16 }, { 73017, 17 }, { 73018, 18 }, { 73019, 19 }, { 73020, 20 }, { 73021, 21 }, { 73022, 22 }, { 73023, 23 } };
            int i = 0, myZip = 0;
            bool deliver = false;
            WriteLine("What is your zip code?");
            myZip = Int32.Parse(ReadLine());
            for (i = 0; i <= 10; i++)
            {
                if (zipCodes[i,0] == myZip)
                {
                    WriteLine("For zip code " + myZip +" our price is " + zipCodes[i,1]);
                    deliver = true;
                    ReadLine();
                    i = 10;
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
