using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_week5
{
    public class Exercise_3
    {
        //        3. Design a Job class for Harold’s Home Services.The class contains four data fields—Job
        //description(for example, “wash windows”), time in hours to complete the Job(for example,
        //3.5), per-hour rate charged for the Job(for example, $25.00), and total fee for the Job(hourly
        //rate times hours). Include properties to get and set each field except the total fee—that field
        //will be read-only, and its value is calculated each time either the hourly fee or the number of
        //hours is set.Overload the + operator so that two Jobs can be added.The sum of two Jobs is a
        //new Job containing the descriptions of both original Jobs(joined by “and”), the sum of the
        //time in hours for the original Jobs, and the average of the hourly rate for the original Jobs.
        //Write a Main() function that demonstrates all the methods work correctly
        public static void DoExercise3()
        {
            Console.WriteLine("\nExercise 3\n");

            Job[] jobs = new Job[3];
            jobs[0] = new Job("Bike Wash", 1, 15);
            jobs[1] = new Job("Car Wash", 3, 25);
            jobs[2] = new Job("Van Wash", 6, 45);

            foreach (var j in jobs)
                Console.WriteLine(j.ToString());

            Job multJob = jobs[1] + jobs[2];
            Console.WriteLine(multJob.ToString());
        }
       
        
        public class Job
        {
            private string _jobDescription;
            private float _jobTime;
            private float _perHourCharge;
            private float _jobTotFee;

            public Job()
            {

            }
            public Job(string jobDescription, float jobTime, float perHourCharge)
            {
                _jobDescription = jobDescription;
                _jobTime = jobTime;
                _perHourCharge = perHourCharge;
                _jobTotFee = CalculatePerHourCharge(jobTime, perHourCharge);
            }

            public static Job operator+(Job a, Job b)
            {
                Job job = new Job();
                job.JobDescription = string.Concat(a.JobDescription + " and " + b.JobDescription);
                job._jobTotFee = a._jobTotFee + b._jobTotFee;
                return job;
            }

            public float CalculatePerHourCharge(float jobTime, float perHourCharge)
            {
                return jobTime * perHourCharge;
            }

            public override string ToString()
            {
                return $"The total price for the service {_jobDescription} is {_jobTotFee} euro";
            }
            public string JobDescription
            {
                get
                {
                    return _jobDescription;
                }
                set
                {
                    _jobDescription = value;
                }
            }
            public float JobTime
            {
                get
                {
                    return -_jobTime;
                }
                set
                {
                    _jobTime = value;
                }
            }
            public float PerHourCharge
            {
                get
                {
                    return _perHourCharge;
                }
                set
                {
                    _perHourCharge = value;
                }
            }
        }
        
    }
}
