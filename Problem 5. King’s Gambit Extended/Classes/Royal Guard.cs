namespace Problem_2._King_s_Gambit.Classes
{
    public class Royal_Guard : Units, IName
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private const int GuardHits = 3;
        public Royal_Guard(string name) : base(name)
        {
            Name = name;
            this.Hits = GuardHits;
        }
        public override void KingisAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}