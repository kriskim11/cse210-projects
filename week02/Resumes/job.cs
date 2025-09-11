using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startDate;
    public string _endDate;


    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startDate} - {_endDate})");
    }
}

