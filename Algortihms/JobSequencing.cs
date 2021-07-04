using System;
using System.Collections;

// https://www.geeksforgeeks.org/job-sequencing-problem/
// https://www.techiedelight.com/job-sequencing-problem-deadlines/

namespace DataStructureAlgorithm.Algortihms
{
    public class Job
    {
        public int JobId;
        public int Profit;
        public int Deadline;

        public Job(int jobId, int profit, int deadline)
        {
            JobId = jobId;
            Profit = profit;
            Deadline = deadline;
        }

    }

    public class custComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Job a = (Job)x;
            Job b = (Job)y;
            if (a.Profit < b.Profit)
            {
                return 1;
            }
            else if (a.Profit == b.Profit)
            {
                return 0;
            }
            else
            {
                return -1;
            }



        }
    }
    public class JobSequencing
    {
        public void JobSequencing_main()
        {
            Job[] jobs = new Job[]{
                new Job(1,20,4),
                new Job(2,10,1),
                new Job(3,40,1),
                new Job(4,30,1),
            };
            var sequence = Schedule(jobs, 4);
            PrintSequence(sequence);
            Job[] jobs1 = new Job[]{
            new Job(1, 15,9), new Job(2, 2, 2),
                new Job(3, 18, 5), new Job(4, 1, 7),
                new Job(5, 25, 4), new Job(6, 20, 2),
                new Job(7, 8, 5), new Job(8, 10, 7),
                new Job(9, 12, 4), new Job(10, 5, 3)};
            sequence = Schedule(jobs1, 10);
            PrintSequence(sequence);

        }


        public int[] Schedule(Job[] jobs, int t)
        {
            int n = jobs.Length;
            custComparer cust = new custComparer();
            Array.Sort(jobs, cust);
            int[] slot = new int[t];
            for (int i = 0; i < t; i++)
            {
                slot[i] = -1;
            }
            foreach (var job in jobs)
            {

                for (int j = job.Deadline - 1; j >= 0; j--)
                {
                    if (slot[j] == -1)
                    {
                        slot[j] = job.JobId;
                        break;
                    }
                }
            }
            return slot;

        }

        public void PrintSequence(int[] sequence)
        {
            foreach (var item in sequence)
            {
                if (item != -1)
                {
                    Console.Write(item);
                    Console.Write("-->");
                }
            }
            Console.WriteLine();
        }
    }
}