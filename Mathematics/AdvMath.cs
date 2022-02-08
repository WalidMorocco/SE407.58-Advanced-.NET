using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics
{
    public class AdvMath
    {
        public double CalcArea(double num1, double num2)
        {
            return num1 * num2;
        }
        public double CalcAverage(List <Double> Nums)
        {
            double sum = 0.0;
            double avg = 0.0;
            for (int i = 0; i < Nums.Count; ++i)
            {
                sum += Nums[i];
            }
            avg = sum / Nums.Count;

            return avg;
        }
        public double CalcValueSq(double num1)
        {
            return Math.Pow(num1,2);
        }
        public double CalcPythagorean(double num1, double num2)
        {
            return Math.Sqrt(CalcValueSq(num1) + CalcValueSq(num2));
        }
    }
}
