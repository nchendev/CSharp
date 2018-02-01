using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is the length of the room? (in ft)");
            int len = Int32.Parse(ReadLine());
            WriteLine("What is the width of the room? (in ft)");
            int wid = Int32.Parse(ReadLine());
            Compute(len,wid);
            ReadLine();
        }
        static void Compute(int x,int y)
        {
            WriteLine("The total cost for painting the room is {0:c}", (2*x*y+4*x*y*9)*6);
        }
    }
}
