using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            String description;
            double timeReq;
            double hourlyRate;
            double totalFee;
            //Made for Harold's Home Services
            setVars(out description, out timeReq, out hourlyRate, out totalFee);
            Job job1 = new Job(description, timeReq, hourlyRate, totalFee);
            setVars(out description, out timeReq, out hourlyRate, out totalFee);
            Job job2 = new Job(description, timeReq, hourlyRate, totalFee);
            Job job3 = job1 + job2;
            WriteLine("Job description: {0}", job3.description);
            WriteLine("Time required for job: {0}", job3.timeReq);
            WriteLine("Hourly rate: {0}", job3.hourlyRate);
            WriteLine("Total Fee: {0}", job3.totalFee);

            ReadLine();
        }
        static void setVars(out String description, out double timeReq, out double hourlyRate, out double totalFee)
        {
            Write("Job description: ");
            description = ReadLine();
            Write("Time required for job: ");
            timeReq = double.Parse(ReadLine());
            Write("Hourly rate: ");
            hourlyRate = double.Parse(ReadLine());
            totalFee = hourlyRate * timeReq;
            WriteLine("Total Fee: {0}", totalFee);
            WriteLine("---------");
        }
    }
    class Job
    {
        public String description;
        public double timeReq;
        public double hourlyRate;
        public double totalFee;

        public Job(String description, double timeReq, double hourlyRate, double totalFee)
        {
            this.description = description;
            this.timeReq = timeReq;
            this.hourlyRate = hourlyRate;
            this.totalFee = totalFee;
        }
        public static Job operator +(Job job1, Job job2)
        {
            String description = job1.description + " and " + job2.description;
            double timeReq = job1.timeReq + job2.timeReq;
            double hourlyRate = job1.hourlyRate + job2.hourlyRate;
            double totalFee = job1.totalFee + job2.totalFee;
            return new DemoJobs.Job(description, timeReq, hourlyRate, totalFee);
        }
    }
}
