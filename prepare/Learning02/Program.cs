using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.CompanyName = "Microsoft";
        job1.StartYear = 2019;
        job1.EndYear = 2022;
        job1.DisplayCompanyDetails();

        Job job2 = new Job();
        job2.JobTitle = "Sanitation Engineer";
        job2.CompanyName = "Apple";
        job2.StartYear = 2020;
        job2.EndYear = 2021;
        job2.DisplayCompanyDetails();

        Resume MyResume = new Resume();
        MyResume.Name = "Michael Motorcycle";
        MyResume.Jobs.Add(job1);
        MyResume.Jobs.Add(job2);

        MyResume.Display();


    }
}
 