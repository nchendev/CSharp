using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 9, 2017
///   Purpose: Program that accepts/rejects a student based on GPA
///            and test score
///-----------------------------------------------------------------
namespace AdmissionModularized
{
    class Program
    {
        static void Main()
        {
            double gpa, testScore;
            WriteLine("What is your gpa?");
            gpa = double.Parse(ReadLine());
            WriteLine("What was your test score?");
            testScore = double.Parse(ReadLine());
            Result(gpa, testScore);
            ReadLine();
        }
        static void Result(double a, double b)
        {
            if (a >= 3 && b >= 60)
            {
                WriteLine("Accept");
            }
            else
            {
                WriteLine("Reject");
            }
        }
    }
}
