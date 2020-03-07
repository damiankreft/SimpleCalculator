using System;

namespace EmailTask3
{
    public class CalculableDivide : Interfaces.ICalculable
    {
        public double GetValue(double numA, double numB)
        {
            try
            {
                if (numB == 0)
                {
                    throw new DivideByZeroException();
                }

                return numA / numB;
            }
            catch(DivideByZeroException divideException)
            {
                if(divideException != null)
                {
                    throw divideException;
                }

                throw new Exception();
            }
        }
    }
}
