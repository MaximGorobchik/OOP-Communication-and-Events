namespace ООП_ЛАБА_11.Classes
{
    public class Dispatcher
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }
        public event NameChangeEventHandler NameChange;
        public void OnNameChange(NameChangeEventArgs args)
        {
            if (Name != null)
            {
                NameChange?.Invoke(this, args);
            }
        }
    }
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
}