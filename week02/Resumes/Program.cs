using System;

class Program
{
    static void Main(string[] args)

    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startDate = "June 2020";
        job1._endDate = "Present";

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Intern";
        job2._startDate = "June 2019";
        job2._endDate = "August 2022";

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
        
    }
}