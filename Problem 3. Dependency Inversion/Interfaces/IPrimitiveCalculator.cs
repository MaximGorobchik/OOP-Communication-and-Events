public interface IPrimitiveCalculator
{
    public int PerformCalculation(int firstOperand, int secondOperand);
    public void ChangeStrategy(IStrategy strategy);
}