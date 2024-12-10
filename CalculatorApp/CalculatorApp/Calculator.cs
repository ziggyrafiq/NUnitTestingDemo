namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException();
            return dividend / divisor;
        }
    }

}
