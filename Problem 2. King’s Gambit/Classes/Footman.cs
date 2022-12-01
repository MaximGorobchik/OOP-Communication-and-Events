namespace Problem_2._King_s_Gambit.Classes
{
    public class Footman : Units, IName
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Footman(string name) : base(name)
        {
            Name = name;
        }
        public override void KingisAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}