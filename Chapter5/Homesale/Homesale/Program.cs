using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homesale
{
    class Program
    {
        static void Main()
        {
            int dAMT = 0, eAMT = 0, fAMT = 0;
            string ans, highest="";
            WriteLine("Which salesperson would you like to call? Type D or danielle, E for edward, or F for Francis: ");
            ans = ReadLine();
            while (ans != "Z" && ans != "z")
            {
                WriteLine("Which salesperson would you like to call? Type D or danielle, E for edward, or F for Francis. Type Z to end the program");
                ans = ReadLine();
                if (ans == "D" || ans == "d")
                {
                    dAMT = dAMT + 1;
                }
                else if (ans == "E" || ans == "e")
                {
                    eAMT = eAMT + 1;
                }
                else if (ans == "F" || ans == "f")
                {
                    fAMT = fAMT + 1;
                }
                else
                {
                    WriteLine("ERROR");
                }
            }
            if ((ans == "Z" )|| (ans == "z"))
            {
                WriteLine("Danielle was chosen {0} times, Edward was chosen {1} times, and Francis was chosen {2} times.", dAMT, eAMT, fAMT);
                WriteLine("The total amount of sales was {0}", dAMT + eAMT + fAMT);
                if (dAMT > eAMT && dAMT > fAMT)
                    highest = "Danielle";
                if (eAMT > dAMT && eAMT > fAMT)
                    highest = "Edward";
                if (fAMT > eAMT && fAMT > dAMT)
                    highest = "Francis";
                WriteLine("{0} has the highest total.", highest);
            }
            ReadLine();
        }
    }
}
