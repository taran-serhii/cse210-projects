public class Resume
{
    // Member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // A method for disaplying the resume
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate trough ech item in the lst to display them one by one
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}