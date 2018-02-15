using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 28, 2017
///   Purpose: Program that tests exception throwing
///-----------------------------------------------------------------
namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(1, 1, 1);
            Order o2 = new Order(100, 12, 21);
            Order o3 = new Order(1200, 0, 12);
            ReadLine();
        }
    }
    class Order
    {
        public Order(double number, double quantity, double dayOrdered)
        {
            try
            {

                bool toThrow = false;
                if (number < 100 || number > 999)
                    toThrow = true;
                if (quantity < 1 || quantity > 12)
                    toThrow = true;
                if (dayOrdered < 1 || dayOrdered > 31)
                    toThrow = true;
                if (toThrow == true)
                {
                    ArgumentException ae = new ArgumentException();
                    throw (ae);
                }
                WriteLine("Object successfully initiated :D");
            }
            catch(ArgumentException ae)
            {
                WriteLine(ae.Message);
            }

        }
    }
    class ArgumentException :Exception
    {
        private static string msg = "Item number is less than 100/more than 999, quantity ordered is less than 1/more than 12, or day ordered is not between 1 and 31.";
        public ArgumentException(): base(msg)
        { }
    }
}
