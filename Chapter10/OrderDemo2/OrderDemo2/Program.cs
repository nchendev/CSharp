using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 7, 2017
///   Purpose: Program that prompts the user to enter Order objects
///            and then return their values
///-----------------------------------------------------------------
namespace OrderDemo2
{
    class Program
    {
        static void Main()
        {
            Order[] orderArray = new Order[5];
            double[] usedNums = new double[5];
            for(int i=0; i <5; i++)
            {
                WriteLine("--------");
                WriteLine("What is the order number?");
                double tempNum = double.Parse(ReadLine());
                for(int j=0; j<i; j++)
                {
                    while (tempNum == usedNums[j])
                    {
                        WriteLine("Please input another, unique order number.");
                        tempNum = double.Parse(ReadLine());
                    }
                }
                usedNums[i] = tempNum;
                double tempNumber = tempNum;
                WriteLine("What is the order name?");
                String tempName = ReadLine();
                WriteLine("How many are being ordered?");
                int tempQuantity= Int32.Parse(ReadLine());
                Order tempOrder = new Order(tempNumber, tempName, tempQuantity);
                orderArray[i] = tempOrder;
            }
            WriteLine("--------");
            for(int i=0;i<5;i++)
            {
                WriteLine("Order " + (i+1)+": "+orderArray[i]);
            }
            ReadLine();
            
        }
    }
    class Order
    {
        double number;
        String name;
        int quantity;
        double totalPrice;
        public Order(double number, String name, int quantity)
        {
            this.number = number;
            this.name = name;
            this.quantity = quantity;
            this.totalPrice = quantity * number;
        }

        public string Equals(Order order1, Order order2)
        {
            if (order1.number == order2.number)
            {
                return (order1 + " and " + order2 + " are equal.");
            }
            else
                return (order1 + " and " + order2 + " are not equal.");
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Order " + name + " is number " + number + ", costs $" + totalPrice + " for " + quantity + ". Its hash code is " + GetHashCode();
        }
    }
}
