namespace Problem_2._King_s_Gambit.Classes
{
    public class King : IName
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public King(string name)
        {
            Name = name;
        }
        public event Respond KingRespond;
        public void KingIsAttacked()
        {
            Console.WriteLine($"King {Name} is under attack!");
            if (KingRespond != null)
            {
                KingRespond?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}