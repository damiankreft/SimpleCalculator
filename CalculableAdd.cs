﻿using System;

namespace EmailTask3
{
    public class CalculableAdd : Interfaces.ICalculable
    {
        public double GetValue(double numA, double numB)
        {
            try
            {
                return numA + numB;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
