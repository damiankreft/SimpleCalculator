namespace EmailTask3
{
    public class CalculationFactory
    {
        public static Interfaces.ICalculable createCalculation(string operation)
        {
            Interfaces.ICalculable calculable = null;
            switch(operation)
            {
                case "+":
                    calculable = new CalculableAdd();
                    break;
                case "-":
                    calculable = new CalculableSubstract();
                    break;
                case "*":
                    calculable = new CalculableMultiply();
                    break;
                case "/":
                    calculable = new CalculableDivide();
                    break;
            }
            return calculable;
        }
    }
}
