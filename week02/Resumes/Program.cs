using System;

/// <summary>
/// This is the Program class for the Resumes project. It creates a Job object and displays its information.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ABC Corp";
        job1._startYear = 2020;
        job1._endYear = 2023;
        job1._salary = 75000m;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "XYZ Inc";
        job2._startYear = 2023;
        job2._endYear = 2025;
        job2._salary = 90000m;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Mary Cerritos";
        resume._email = "Mary.Cerritos@gmail.com";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();

    }
}