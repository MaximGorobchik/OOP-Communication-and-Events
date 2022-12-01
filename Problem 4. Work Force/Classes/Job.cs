public class Job
{
    private string Name;
    private int WorkHoursPerWeek;
    private IEmployee employee;
    public Job(string name, int hours, IEmployee employee) 
    { 
        this.Name = name;
        this.WorkHoursPerWeek = hours;
        this.employee = employee;
    }
    public event EventHandler<JobEventArgs> JobFinished;
    public void Update()
    {
        this.WorkHoursPerWeek -= this.employee.WorkHoursPerWeek;
        if(this.WorkHoursPerWeek <= 0)
        {
            this.OnJobFinished();
        }
    }
    protected virtual void OnJobFinished()
    {
        Console.WriteLine($"Job {this.Name} done!");
        if(this.JobFinished != null)
        {
            this.JobFinished?.Invoke(this, new JobEventArgs(this));
        }
    }
    public override string ToString()
    {
        return $"Job: {this.Name} Hours Remaining: {this.WorkHoursPerWeek}";
    }
}   