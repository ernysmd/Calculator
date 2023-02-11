using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_refactor
{
    public class Calculator
    {
        public int Add(double first, double second)
        {
            return (int)(first + second);
        }

        public int Subtract(double first, double second)
        {
            return (int)(first - second);
        }

        public double Multiply(double first, double second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
