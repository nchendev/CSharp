using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            int drawers = NoDrawers();
            int wood = TypeWood();
            int totalCost = CalculateCost(drawers, wood);
            WriteLine("Your total cost is {0}", totalCost);
            ReadLine();
        }
        static int NoDrawers()
        {
            WriteLine("How many drawers are there in the desk?");
            return Int32.Parse(ReadLine());
        }
        static int TypeWood()
        {
            WriteLine("What kind of wood is the table? Type  m for mahogany, o for oak, or p for pine.");
            String woodType = ReadLine();
            if (woodType == "o")
                return 100;
            else if (woodType == "p")
                return 140;
            else
                return 180;
        }
        static int CalculateCost(int drawers, int wood)
        {
            return wood + 30 * drawers;
        }
    }
}
