using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "IT support";
        job1._company = "Selcomp";
        job1._startYear = 2010;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "Technical Sales Consultant";
        job2._company = "CEMES";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Curriculum myResume = new Curriculum();
        myResume._name = "Miguel Arcos";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();        
    }
}