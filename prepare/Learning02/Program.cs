using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    
        // Creating new object resume
        Resume resume = new Resume();
        // Adding the name variable to resume instance
        resume._name = "Allison Miller";
        // Adding job instances to resume list
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Calling a method to display the whole resume
        resume.DisplayResume();

    }
}