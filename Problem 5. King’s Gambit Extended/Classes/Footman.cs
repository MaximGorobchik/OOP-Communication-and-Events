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
        private const int FootmanHits = 2;
        public Footman(string name) : base(name)
        {
            Name = name;
            this.Hits = FootmanHits;
        }
        public override void KingisAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}