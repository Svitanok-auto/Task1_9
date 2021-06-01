using System;

namespace Practice_9
{
    public class Calculator
    {
        public double x;
        public double y;
        public Calculator(double xVariable, double yVariable)
        {
            x = xVariable;
            y = yVariable;
        }
        public Calculator() { }

        public double Add(double x, double y)
        {
            return Math.Round(x + y, 2);
        }

        public double Substract(double x, double y)
        {
            return Math.Round(x - y, 2);
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                return default;
            }
            else
            {
                return Math.Round(x / y, 2);
            }    
        }

        public double Multiply(double x, double y)
        {
            return Math.Round(x * y, 2);
        }
    }
}
