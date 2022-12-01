namespace ООП_ЛАБА_11.Classes
{
    public class NameChangeEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public NameChangeEventArgs(string name)
        {
            Name = name;

        }
    }
}