public abstract class Units : IName
{
    public string Name { get; set; }
    protected Units(string name)
    {
        this.Name = name;
    }
    public abstract void KingisAttacked(object sender, EventArgs args);
}