using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: December 9, 2016
///   Purpose: Program that simulates salespeople and their sales
///-----------------------------------------------------------------
namespace HomeSales
{
    class Program
    {
        static void Main()
        {
            String[,] salespeople = { { "Danielle", "D", "0" }, { "Edward", "E", "0" }, { "Francis", "F", "0" } };
            string ans, highest = "";
            WriteLine("Which salesperson would you like to call? Type D or danielle, E for edward, or F for Francis: ");
            ans = ReadLine();
            while (ans != "Z" && ans != "z")
            {
                WriteLine("Which salesperson would you like to call? Type D or danielle, E for edward, or F for Francis. Type Z to end the program");
                ans = ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    if (ans.ToUpper() == Convert.ToString((salespeople[i, 1])))
                        salespeople[i, 2] = Convert.ToString(Int32.Parse(salespeople[i, 2]) + 1);
                }
            }
            if (ans.ToUpper() == "Z")
            {
                WriteLine("Danielle was chosen {0} times, Edward was chosen {1} times, and Francis was chosen {2} times.", salespeople[0, 2], salespeople[1, 2], salespeople[2, 2]);
                WriteLine("The total amount of sales was {0}", Convert.ToInt32(salespeople[0, 2]) + Convert.ToInt32(salespeople[1, 2]) + Convert.ToInt32(salespeople[2, 2]));
                if (Int32.Parse(salespeople[0, 2]) > Int32.Parse(salespeople[1, 2]) && Int32.Parse(salespeople[0, 2]) > Int32.Parse(salespeople[2, 2]))
                    highest = "Danielle";
                if (Int32.Parse(salespeople[1, 2]) > Int32.Parse(salespeople[0, 2]) && Int32.Parse(salespeople[1, 2]) > Int32.Parse(salespeople[2, 2]))
                    highest = "Edward";
                if (Int32.Parse(salespeople[2, 2]) > Int32.Parse(salespeople[1, 2]) && Int32.Parse(salespeople[2, 2]) > Int32.Parse(salespeople[0, 2]))
                    highest = "Francis";
                WriteLine("{0} has the highest total.", highest);
            }
            ReadLine();
        }
    }
}
