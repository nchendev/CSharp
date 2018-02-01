using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PackageDemo
{
    class Program
    {
        static void Main()
        {
            WriteLine("--Package Demo--");
            WriteLine("--regular package--");
            Package package1 = new Package();
            WriteLine("--package with insurance--");
            InsuredPackage package2 = new InsuredPackage();
            WriteLine("");
            WriteLine("Regular package cost = " + package1.delPrice);
            WriteLine("Insured package cost = " + package2.packageValue);
            ReadLine();
        }
    }
    class Package
    {
        public int idNumber;
        public string recepName;
        public int weight;
        protected double dp;
        public double delPrice;
        public Package()
        {
            WriteLine("What is the id number?");
            idNumber = Int32.Parse(ReadLine());
            WriteLine("What is the receptor's name?");
            recepName = ReadLine();
            WriteLine("What is the weight of the object?");
            weight = Int32.Parse(ReadLine());
            if (weight <= 32)
                delPrice = 5;
            else
                delPrice = (weight - 32) * .12 + 5;
        }
    }
    
    class InsuredPackage:Package
    {
        protected double pv;
        public double packageValue;
        public InsuredPackage()
        {
            if (delPrice <= 20)
                packageValue = delPrice + 1;
            else
                packageValue = delPrice + 2.5;
        }
        
    }
}
