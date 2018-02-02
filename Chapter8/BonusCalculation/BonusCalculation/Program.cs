using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 20, 2017
///   Purpose: Program that calculates and displays a salaryman's
///            wages, bonus, and total pay
///-----------------------------------------------------------------
namespace BonusCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary, iBonus;
            double dBonus;
            WriteLine("What is your salary?");
            salary = Int32.Parse(ReadLine());
            WriteLine("What is your bonus?(percentage, in decimal form)");
            dBonus = double.Parse(ReadLine());
            WriteLine("What is your bonus?(whole number of dollars)");
            iBonus = Int32.Parse(ReadLine());
            BonusCalculations(salary, dBonus);
            BonusCalculations(salary, iBonus);
            ReadLine();
        }
        static void BonusCalculations(double salary, double dBonus)
        {
            WriteLine("The salary is: " + salary);
            WriteLine("The bonus is: " + dBonus);
            WriteLine("The total is {0}", salary + salary * dBonus);
        }
        static void BonusCalculations(double salary, int iBonus)
        {
            WriteLine("The salary is: " + salary);
            WriteLine("The bonus is: " + iBonus);
            WriteLine("The total is {0}", salary + iBonus);
        }
    }
}
