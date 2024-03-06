using System;
using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2022;
        job1._startYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "McDonalds";
        job2._endYear = 2018;
        job2._startYear = 2000;
    
        Resume resume1 = new Resume();
        resume1._name = "John";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}