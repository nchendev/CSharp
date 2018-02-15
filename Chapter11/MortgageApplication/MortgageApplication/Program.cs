using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 24, 2017
///   Purpose: Program that creates MortgageApp objects and throws
///            an exception if the credit score entered is not valid
///-----------------------------------------------------------------
namespace MortgageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trigger = false;
            int i = 0;
            string tempName;
            double tempCreditScore;

            while (trigger == false)
            {
                i += 1;
                WriteLine("-- Applicant " + i + " --");
                WriteLine("What is the applicant's name?");
                tempName = ReadLine();
                WriteLine("What is the applicant's credit score?");
                try
                {
                    tempCreditScore = double.Parse(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("Invalid score");
                    tempCreditScore = 0;
                }
                MortgageApp tempMort = new MortgageApp(tempName, tempCreditScore);
                WriteLine("type 'end' to end or anything else to continue");
                if (ReadLine() == "end")
                    trigger = true;

            }
        }
    }
    class MortgageApp
    {
        public string name;
        public double creditScore;
        public bool verdict;
        public MortgageApp(string name, double creditScore)
        {
            verdict = determine(name, creditScore);
            if (verdict == true)
                WriteLine("Applicant accepted");
            if (verdict == false)
                WriteLine("Applicant rejected");

            WriteLine(" ");
        }
        public static bool determine(string name, double creditScore)
        {
            bool ans = true;
            if (!(creditScore >= 300 && creditScore <= 800))
            {
                ans = false;
            }
            return ans;
        }
    }
}
