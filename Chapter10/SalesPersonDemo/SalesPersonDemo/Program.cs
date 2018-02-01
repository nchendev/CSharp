using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SalesPersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempFName;
            string tempLName;
            int tempCommRate;
            WriteLine("--Real Estate Salesperson--");
            WriteLine("What is the salesperson's first name?");
            tempFName = ReadLine();
            WriteLine("What is the salesperson's last name?");
            tempLName = ReadLine();
            WriteLine("What is the commission rate?");
            tempCommRate = Int32.Parse(ReadLine());
            RealEstateSalesperson salesperson1 = new RealEstateSalesperson(tempFName, tempLName, tempCommRate);
            WriteLine(salesperson1.SalesPitch());
            WriteLine(" ");
            WriteLine("--Girl Scout Salesperson--");
            WriteLine("What is the salesperson's first name?");
            tempFName = ReadLine();
            WriteLine("What is the salesperson's last name?");
            tempLName = ReadLine();
            GirlScout salesperson2 = new GirlScout(tempFName, tempLName);
            WriteLine(salesperson2.SalesPitch());
            ReadLine();
        }

    }
    abstract class Salesperson
    {
        public string fName;
        public string lName;
        public string fullName;
        public Salesperson(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
            fullName = combName(fName, lName);
        }
        public string combName(string fName, string lName)
        {
            return fName + " " + lName;
        }
    }
    public interface ISellable
    {
        string SalesPitch();
    }
    class RealEstateSalesperson:Salesperson , ISellable
    {
        public double totVal = 0;
        public double totComm = 0;
        public double commRate;
        public RealEstateSalesperson(string fName, string lName, double commRate) : base(fName, lName)
        {
            this.commRate = commRate;
        }
        public string SalesPitch()
        {
            return "I am an evil salesperson and I know my stuff!";
        }
            
    }
    
    class GirlScout:Salesperson , ISellable
    {
        public int boxesSold = 0;
        public GirlScout(string fName, string lName) : base(fName, lName)
        {
            WriteLine("How many boxes were sold?");
            boxesSold = Int32.Parse(ReadLine());

        }
        public string SalesPitch()
        {
            return "I am a little girl and you better buy my cookies!";
        }

    }
}
