using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string gNamec;
            double sDatec;
            int attendeesc;
            Conference[] confArray = new Conference[5];
            for(int i=0; i <5; i++)
            {
                WriteLine("_____________");
                WriteLine("CONFERENCE {0}", i+1);
                WriteLine("-------------");
                GetData(out gNamec, out sDatec, out attendeesc);
                confArray[i] = new Conference(gNamec, sDatec, attendeesc);
            } 
            
            Array.Sort(confArray);
            WriteLine("Sorted Conferences by no. Attendees: ");
            for (int k = 0; k < 5; k++)
            {
                Conference tempConf = confArray[k];
                Write(tempConf.gName + ", ");   
            }

        ReadLine();
        }
        public static void GetData(out string gNamec, out double sDatec, out int attendeesc)
        {
            Write("group name: ");
            gNamec = ReadLine();
            Write("starting date(format: MMDDYY): ");
            sDatec = Int32.Parse(ReadLine());
            Write("number of attendees: ");
            attendeesc = Int32.Parse(ReadLine());
        }
    }
    class Conference :IComparable
    {
        public string gName;
        public double sDate;
        public int attendees;

        public Conference(string gName, double sDate, int attendees)
        {
            this.gName = gName;
            this.sDate = sDate;
            this.attendees = attendees;
        }

        int IComparable.CompareTo(Object comparedTo)
        {
            int returnVal;
            Conference temp = (Conference)comparedTo;
            if (this.attendees > temp.attendees)
                returnVal = 1;
            else
                if (this.attendees < temp.attendees)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}
