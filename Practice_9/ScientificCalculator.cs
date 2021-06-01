using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_9
{
    public class ScientificCalculator : Calculator
    {
        public List<int> list;
        public ScientificCalculator(double xVariable, double yVariable) : base(xVariable, yVariable) {}

        public ScientificCalculator(List<int> listValues) 
        {
            list = listValues;
        }
        public ScientificCalculator(){ }

        public double Pow(double x, double y)
        {
            return Math.Round(Math.Pow(x, y), 2);
        }

        public double Percents(double x, double y)
        {
            return Math.Round((x / y) * 100, 2);
        }

        public double Mod(double x, double y)
        {
            return Math.Round(x % y, 2); ;
        }

        public int ListValuesSum(List<int> listValues)
        {
            int sum = default(int);
            for (int i = 0; i < listValues.Count; i++)
            {
                sum += listValues[i];
            }
            return sum;
        }

        public int ListMinValue(List<int> listValues)
        {
            return listValues.Min();
        }

        public int ListMaxValue(List<int> listValues)
        {
            return listValues.Max();
        }
    }
}
