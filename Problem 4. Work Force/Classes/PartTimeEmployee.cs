public class PartTimeEmployee : IEmployee
{
    private const int hours = 20;
    public string Name { get; }
    public PartTimeEmployee(string name)
    {
        this.Name = name;
    }
    public int WorkHoursPerWeek => hours;
}