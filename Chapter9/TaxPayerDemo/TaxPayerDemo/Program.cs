using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: February 3, 2017
///   Purpose: Program that tests a taxpayer class
///-----------------------------------------------------------------
namespace TaxPayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer[] tpArray = new TaxPayer[10];
            for (int i = 0; i < 10; i++)
            {
                WriteLine("What is this Taxpayer's SSN?");
                string ssnc = ReadLine();
                WriteLine("What is this Taxpayer's gross income?");
                double grossIncc = double.Parse(ReadLine());
                WriteLine("What is this Taxpayer's income tax owed?");
                double incTaxOwedc = double.Parse(ReadLine());
                tpArray[i] = new TaxPayer(ssnc, grossIncc, incTaxOwedc);
                WriteLine("TaxPayer{0} initialized!", i);
            }
        }
    }
    class TaxPayer
    {
        public String ssn;
        public double grossInc;
        public double incTaxOwed;
        public double incTaxRate;
        public double incTax;
        public TaxPayer(String ssn, double grossInc, double incTaxOwed)
        {
            if (grossInc < 30000)
                incTaxRate = .15;
            else
                incTaxRate = .28;
            incTax = grossInc * incTaxRate;
            WriteLine("This taxpayer's SSN is {0}, his annual gross income is {1}, his income tax owed is {2}, and his income tax is {3}", ssn, grossInc, incTaxOwed, incTax);
        }
    }
}
