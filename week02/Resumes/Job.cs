
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    public decimal _salary;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} - {_salary:C}");
    }
    
}