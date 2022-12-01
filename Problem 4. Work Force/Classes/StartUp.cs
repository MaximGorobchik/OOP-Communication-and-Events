public class StartUp
{
    private JobList jobs;
    private List<IEmployee> employees;
    private Job job;
    public StartUp()
    {
        this.jobs = new JobList();
        this.employees= new List<IEmployee>();
    }

    public void start()
    {
        var inputline = Console.ReadLine();
        while(!inputline.Equals("End"))
        {
            var input_info = inputline.Split(" ");
            if (input_info[0].Equals("Job"))
            {
                var jobName = input_info[1];
                var hoursofWorkRequired = int.Parse(input_info[2]);
                IEmployee employeeName = this.employees.FirstOrDefault(x => x.Name.Equals(input_info[3]));
                this.job = new Job(jobName,hoursofWorkRequired,employeeName);
                this.jobs.Add(job);
                job.JobFinished += this.jobs.OnJobFinished;
            }
            if (input_info[0].Equals("StandartEmployee"))
            {
                var employeeName = input_info[1];
                StandardEmployee standardEmployee = new StandardEmployee(employeeName);
                this.employees.Add(standardEmployee);
            }
            if (input_info[0].Equals("PartTimeEmployee"))
            {
                var employeeName = input_info[1];
                PartTimeEmployee partTimeEmployee = new PartTimeEmployee(employeeName);
                this.employees.Add(partTimeEmployee);
            }
            if (input_info[0].Equals("Pass"))
            {
                foreach(Job job in this.jobs.ToArray())
                {
                    job.Update();
                }
            }
            if (input_info[0].Equals("Status"))
            {
                foreach (Job job in this.jobs)
                {
                    Console.WriteLine(job.ToString());
                }
            }
            inputline = Console.ReadLine();
        }
    }
}
