using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
            int high, low, sum, average;
            fillArray(ref integers);
            calculate(ref integers, out high, out low, out sum, out average);
            WriteLine("The highest value is {0}, the lowest value is {1}, the sum of values is {2}, and the arithmetic average is {3}.", high, low, sum, average);
            ReadLine();
        }
        static void fillArray(ref int[] array)
        {
            for (int i = 0; i < 20; i++)
            {
                String entryLine;
                int value;
                WriteLine("Give me an integer to add to the array {0}/20.", i);
                entryLine = ReadLine();
                while(!int.TryParse(entryLine, out value))
                    {
                    WriteLine("Nah that's not an integer. Try again.");
                    entryLine = ReadLine();
                    }
                array[i] = Int32.Parse(entryLine);
            }
        }
        static void calculate(ref int[] array, out int high, out int low, out int sum, out int average)
        {
            Array.Sort(array);
            high = array[19];
            low = array[0];
            sum = 0;
            for (int i = 0; i < 20; i++)
                sum += array[i];
            average = sum / 20;
        }
    }
}
