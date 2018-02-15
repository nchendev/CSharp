using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 28, 2017
///   Purpose: Program that tests exception catching 
///-----------------------------------------------------------------
namespace OrderExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempNumber;
            int tempQuantity;
            int tempDayOrdered;
            Order[] orderArray = new Order[5];
            for(int i=0; i<5;i++)
            {
                WriteLine("----------------------------------------------");
                WriteLine("Please input the number for order " + i+". Bear in mind that invalid values will be set to 0.");
                try
                {
                    tempNumber = Int32.Parse(ReadLine());
                }
                catch (Exception)
                {
                    tempNumber = 0;
                }

                WriteLine("Please input the quantity for order " + i + ". Bear in mind that invalid values will be set to 0.");
                try
                {
                    tempQuantity = Int32.Parse(ReadLine());
                }
                catch(Exception)
                {
                    tempQuantity = 0;
                }
                WriteLine("Please input the day ordered for order " + i + ". Bear in mind that invalid values will be set to 0.");
                try
                {
                    tempDayOrdered = Int32.Parse(ReadLine());
                }
                catch(Exception)
                {
                    tempDayOrdered = 0;
                }
                WriteLine("----------------------------------------------");
                Order tempOrder = new Order(tempNumber, tempQuantity, tempDayOrdered);
                orderArray[i] = tempOrder;
                WriteLine("----------------------------------------------");
            }
            WriteLine("");
            WriteLine("--RESULTS--");
            WriteLine("Order 1"+orderArray[0]);
            WriteLine("Order 2" + orderArray[1]);
            WriteLine("Order 3" + orderArray[2]);
            WriteLine("Order 4" + orderArray[3]);
            WriteLine("Order 5" + orderArray[4]);
            ReadLine();
        }
    }
    class Order
    {
        double number;
        double quantity;
        double dayOrdered;
        public Order(double number, double quantity, double dayOrdered)
        {
            this.number = number;
            this.quantity = quantity;
            this.dayOrdered = dayOrdered;
            try
            {
                bool toThrow = false;
                if (number < 100 || number > 999)
                    if (number != 0)
                        toThrow = true;
                if (quantity < 1 || quantity > 12)
                    if (quantity != 0)
                        toThrow = true;
                if (dayOrdered < 1 || dayOrdered > 31)
                    if (dayOrdered != 0)
                        toThrow = true;
                if (toThrow == true)
                {
                    ArgumentException ae = new ArgumentException();
                    throw (ae);
                }
                WriteLine("Object successfully initiated :D");
            }
            catch (ArgumentException ae)
            {
                WriteLine(ae.Message);
                this.number = 0;
                this.quantity = 0;
                this.dayOrdered = 0;
            }
        }
        public override string ToString()
        {
            return ", number:" + number + ", quantity: " + quantity + ", day ordered:" + dayOrdered;
        }
    }
    class ArgumentException : Exception
    {
        private static string msg = "Item number is less than 100/more than 999, quantity ordered is less than 1/more than 12, or day ordered is not between 1 and 31.";
        public ArgumentException() : base(msg)
        { }
    }

    
}
