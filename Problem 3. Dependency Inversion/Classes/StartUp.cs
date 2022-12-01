using System.Security.Cryptography.X509Certificates;

public class StartUp
{
    private Primitive_Calculator calculator;
    private Dictionary<char, IStrategy> calc;

    public StartUp()
    {
        this.calculator = new Primitive_Calculator();
        this.calc = new Dictionary<char, IStrategy>();
        this.GetStrategy();
    }

    public void start()
    {
        var inputline = Console.ReadLine();
        while(!inputline.Equals("End"))
        {
            var input_info = inputline.Split(" ");
            if (input_info[0].Equals("mode"))
            {
                IStrategy strategy = this.calc[input_info[1][0]];
                this.calculator.ChangeStrategy(strategy);
            }
            else
            {
                int firtsOperand = int.Parse(input_info[0]);
                int secondOperand = int.Parse(input_info[1]);
                Console.WriteLine($"{this.calculator.PerformCalculation(firtsOperand,secondOperand)}");
            }
            inputline= Console.ReadLine();
        }
    }
    private void GetStrategy()
    {
        this.calc.Add('+', new Add());
        this.calc.Add('-', new Subtract());
        this.calc.Add('/', new Divide());
        this.calc.Add('*', new Multiply());
    }
}