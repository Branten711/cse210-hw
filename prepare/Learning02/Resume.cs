public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("JOBS: ");
        foreach (var job in _jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }

    }
}