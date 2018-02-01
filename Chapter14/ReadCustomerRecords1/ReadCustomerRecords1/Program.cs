using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace ReadCustomerRecords1
{
    class Program
    {
        static void Main()
        {
            FileStream file = new FileStream("customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line;
            line = reader.ReadLine();
            while(line!= null)
            {
                WriteLine("Id Number: "+line);
                line = reader.ReadLine();
                WriteLine("Name: "+line);
                line = reader.ReadLine();
                WriteLine("Balance Owed: "+line);
                line = reader.ReadLine();
                WriteLine("");
            }
            reader.Close();
            file.Close();
            ReadLine();
        }
    }
    class ReadNameFile
    {

    }
}
