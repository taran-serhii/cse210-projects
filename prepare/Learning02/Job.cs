public class Job
{
    // Member variables
    public string _jobTitle = "";
    public string _companyName = "";
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }

    // A method that display's a job title, company name, start and end years in specific formating.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}