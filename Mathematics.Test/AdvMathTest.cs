using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void TestCalcArea()
        {
            var math = new AdvMath();
            var result = math.CalcArea(4, 5);
            Assert.True(result == 20);
        }
        [Fact]
        public void TestCalcAverage()
        {
            var math = new AdvMath();
            List<Double> Avg = new List<Double>();
            Avg.Add(1);
            Avg.Add(2);
            Avg.Add(3);
            var result = math.CalcAverage(Avg);
            Assert.True(result == 2);
        }
        [Fact]
        public void TestCalcValueSq()
        {
            var math = new AdvMath();
            var result = math.CalcValueSq(5);
            Assert.True(result == 25);
        }
        [Fact]
        public void TestDivideNumbers()
        {
            var math = new AdvMath();
            var result = math.CalcPythagorean(3, 4);
            Assert.True(result == 5);
        }
    }
}
