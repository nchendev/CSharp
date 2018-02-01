using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TaxPayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer[] tpArray = new TaxPayer[3];
            for (int i = 0; i < 3; i++)
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
            Array.Sort(tpArray);
            WriteLine("Here are the taxpayers sorted by income tax owed: ");
            for(int i=0; i<10; i++)
            {
                Write("Taxpayer {0} with {1}, ", tpArray[i], tpArray[i].incTaxOwed.ToString("C"));
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
