public class Primitive_Calculator : IPrimitiveCalculator
{
    private IStrategy calculatorStrategy;
    public Primitive_Calculator()
    {
        this.calculatorStrategy = new Add();
        this.calculatorStrategy = new Divide();
        this.calculatorStrategy = new Multiply();
        this.calculatorStrategy = new Subtract();

    }
    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        return this.calculatorStrategy.Calculation(firstOperand, secondOperand);
    }
    public void ChangeStrategy(IStrategy strategy)
    {
        this.calculatorStrategy = strategy;
    }
}