using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 2, 2017
///   Purpose: Program that compares 4 orders and prints out their
///            values
///-----------------------------------------------------------------
namespace OrderDemo
{
    class Program
    {
        static void Main()
        {
            Order order1 = new Order(12, "ordahwun", 12);
            WriteLine(order1.ToString());
            Order order2 = new Order(12, "ordahdooo", 6);
            WriteLine(order2.ToString());
            Order order3 = new Order(12, "ordahtree", 20);
            WriteLine(order3.ToString());
            Order order4 = new Order(8, "ordahfo", 5);
            WriteLine(order4.ToString());


            WriteLine("Order 1 == Order 2: " + order1.Equals(order2));
            WriteLine("Order 1 == Order 3: " + order1.Equals(order3));
            WriteLine("Order 1 == Order 4: " + order1.Equals(order4));

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
