public class StandardEmployee : IEmployee
{
    private const int hours = 40;
    public string Name { get; }
    public StandardEmployee(string name)
    {
        this.Name= name;
    }
    public int WorkHoursPerWeek => hours;
}