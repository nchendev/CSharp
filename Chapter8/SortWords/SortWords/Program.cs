using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: January 24, 2017
///   Purpose: Program that sorts a String array and returns its
///            contents
///-----------------------------------------------------------------
namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = new String[] { "","","","","","","","","",""};
            magic(ref words);
        }
        static void magic(ref String[] words)
        {
            int i = 0, stahp = 0;
            string reply;
            WriteLine("Give me a word, or type stop to stop.");
            words[0] = ReadLine();
            while (stahp != 1)
            {
                i += 1;
                WriteLine("Give me a word, or type stop to stop.");
                reply = ReadLine();
                if (reply != "stop")
                {
                    words[i] = reply;
                }
                else
                    stahp = 1;
                
            }
            //for (int k = 0; k < i; k++)
              //  Write(words[k]);
            Array.Sort(words);
            WriteLine("");
            for (int j = 0; j < i; j++)
                Write(words[j] + " ");
            ReadLine();
        }
    }
}
