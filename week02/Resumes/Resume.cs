using System;

public class Resume
{
    public string _name;
    public string _email;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Email: {_email}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}