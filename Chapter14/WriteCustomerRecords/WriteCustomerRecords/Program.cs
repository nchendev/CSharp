using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace WriteCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cu1 = new Customer();
            FileStream outFile = new FileStream("customer.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine(cu1.idNum);
            writer.WriteLine(cu1.name);
            writer.WriteLine(+cu1.balanceOwed);

            writer.Close();
            outFile.Close();
        }
    }
    class Customer
    {
        public int idNum;
        public string name;
        public double balanceOwed;
        public Customer()
        {
            WriteLine("What is the ID Number of the Customer?");
            idNum = Int32.Parse(ReadLine());
            WriteLine("What is the Name of the Customer?");
            name = ReadLine();
            WriteLine("What is the balance owed by " + name + "?");
            balanceOwed = double.Parse(ReadLine());
        }
    }
}
