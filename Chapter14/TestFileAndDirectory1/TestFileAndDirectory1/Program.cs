using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace TestFileAndDirectory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans="lol";
            WriteLine("-----------------------------------");
            WriteLine("Welcome to Test File and Directory!");
            WriteLine("-----------------------------------");
            while (ans != "end")
            {
                WriteLine("");
                WriteLine("Enter a directory: ");
                ans = ReadLine();
                if (Directory.Exists(ans))
                {
                    String[] listOfDir;
                    listOfDir = Directory.GetFiles(ans);
                    for (int i = 0; i < listOfDir.Length; i++) 
                    {
                        WriteLine(listOfDir[i]);
                    }
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("ERROR! DIRECTORY DOES NOT EXIST!");
                    ForegroundColor = ConsoleColor.Gray;
                }
                    
            }
        }
    }
}
