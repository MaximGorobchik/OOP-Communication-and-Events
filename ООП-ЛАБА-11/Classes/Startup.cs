namespace ООП_ЛАБА_11.Classes
{
    public class StartUp
    {
        Dispatcher dispatcher = new Dispatcher();
        Handler handler = new Handler();

        public void Start()
        {

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var inputline = Console.ReadLine();
            while (!inputline.Equals("End"))
            {
                dispatcher.Name = inputline;
                inputline = Console.ReadLine();
            }
        }
    }
}