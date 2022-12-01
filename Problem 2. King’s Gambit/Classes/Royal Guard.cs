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
        public Royal_Guard(string name) : base(name)
        {
            Name = name;
        }
        public override void KingisAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}