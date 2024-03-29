﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: October 1, 2016
///   Purpose: Program that accepts/rejects students based on their
///            gpa and test score.
///-----------------------------------------------------------------
namespace Admission
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
            if (gpa >= 3 && testScore >= 60)
            {
                WriteLine("Accept");
            }
            else
            {
                WriteLine("Reject");
            }
            ReadLine();
        }
    }
}
