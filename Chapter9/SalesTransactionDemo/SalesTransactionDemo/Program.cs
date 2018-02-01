using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        public String name;
        public double salesAmount;
        public double commission;
        private readonly double commissionRate;
        public SalesTransaction(string name, double salesAmount, double commissionRate)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commissionRate = commissionRate;
            commission = salesAmount * commissionRate;

            WriteLine("Name: {0}", this.name);
            WriteLine("Sales Amount: {0}", this.salesAmount);
            WriteLine("Commission Rate: {0}", this.commissionRate);
            WriteLine("Commission: {0}", commission);
        }
        public SalesTransaction(string name, double salesAmount)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            commissionRate = 0;
            commission = salesAmount * commissionRate;

            WriteLine("Name: {0}", this.name);
            WriteLine("Sales Amount: {0}", this.salesAmount);
            WriteLine("Commission Rate: {0}", commissionRate);
            WriteLine("Commission: {0}", commission);
        }
        public SalesTransaction(string name)
        {
            this.name = name;
            salesAmount = 0;
            commissionRate = 0;
            commission = salesAmount * commissionRate;

            WriteLine("Name: {0}", this.name);
            WriteLine("Sales Amount: {0}", salesAmount);
            WriteLine("Commission Rate: {0}", commissionRate);
            WriteLine("Commission: {0}", commission);
        }
        public static SalesTransaction operator +(SalesTransaction salesTransaction1, SalesTransaction salesTransaction2)
        {
            String name = salesTransaction1.name + " and " + salesTransaction2.name;
            double salesAmount = salesTransaction1.salesAmount +  salesTransaction2.salesAmount; 
            double commissionRate = salesTransaction1.commissionRate + salesTransaction2.commissionRate; 
            double commission = salesAmount * commissionRate;
            return new SalesTransaction(name, salesAmount, commissionRate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalesTransaction salesTransaction1 = new SalesTransaction("Arck", 15.00, 0.20);
            WriteLine();
            SalesTransaction salesTransaction2 = new SalesTransaction("Arck", 15.00, 0);
            WriteLine();
            SalesTransaction salesTransaction3 = new SalesTransaction("Arck", 0, 0);
            WriteLine();
            SalesTransaction salesTransaction4 = salesTransaction1 + salesTransaction2;
            ReadLine();
        }
    }
}
