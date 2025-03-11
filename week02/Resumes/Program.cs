using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine("");

        Job job1 = new Job();

        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1968;
        job1._endYear = 2010;

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Manager";
        job2._startYear = 1999;
        job2._endYear = 2092;
        
        /*
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);

        job1.Display();
        job2.Display();*/

        Resume myResume = new Resume();
        myResume._name = "Elder Arcila";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        /*
        Console.WriteLine(myResume._jobs[0]._jobTitle);*/

        Console.WriteLine($"Name: {myResume._name}");
        Console.WriteLine("Jobs:");
        myResume.Display();

    }
}