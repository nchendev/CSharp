using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace FindCustomerRecords
{
    class Program
    {
        static void Main()
        {
            string input="0", name;
            int ans = 0, num;
            const int end = 999;
            FileStream inFile = new FileStream("customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            while (ans != end)
            {
                WriteLine("Type in a minimum balance or 999 to end");
                try
                {
                    num = Int32.Parse(ReadLine());
                    if (num == 999)
                        ans = end;
                }
                catch (Exception e)
                {
                    WriteLine("invalid entry");
                    WriteLine("Type in an id number or end to end");
                    num = Int32.Parse(ReadLine());
                }
                finally
                {
                    WriteLine("");
                }
                inFile.Seek(0, SeekOrigin.Begin);

                input = reader.ReadLine();
                name = reader.ReadLine();
                input = reader.ReadLine();
                while (input != null)
                {
                    if (Int32.Parse(input) >= num)
                    {
                        WriteLine(name);
                    }
                    input = reader.ReadLine();
                    name = reader.ReadLine();
                    input = reader.ReadLine();
                }
                WriteLine("");
            }
            ReadLine();
        }
    }
}
