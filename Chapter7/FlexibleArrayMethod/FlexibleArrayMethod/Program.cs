using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 18, 2017
///   Purpose: Program that demonstrates the passage of arrays thru
///            a method
///-----------------------------------------------------------------
namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            PassArray(array1);
            PassArray(array2);
            PassArray(array3);
            ReadLine();
        }
        static void PassArray(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                WriteLine("{0}", array[i]);
                total = total + array[i];
            }
            WriteLine("Total of array: {0}", total);
        }
    }
}
