namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 4, 7)]
        [TestCase(-1, -2, -3)]
        public void Add_ValidInput_ReturnsCorrectResult(double num1, double num2, double expectedResult)
        {
            var result = calculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(3, 2, 1)]
        [TestCase(7, 4, 3)]
        [TestCase(-1, -2, 1)]
        public void Subtract_ValidInput_ReturnsCorrectResult(double num1, double num2, double expectedResult)
        {
            var result = calculator.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 3, 6)]
        [TestCase(4, 4, 16)]
        [TestCase(-1, -2, 2)]
        public void Multiply_ValidInput_ReturnsCorrectResult(double num1, double num2, double expectedResult)
        {
            var result = calculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(6, 2, 3)]
        [TestCase(16, 4, 4)]
        [TestCase(-2, -2, 1)]
        public void Divide_ValidInput_ReturnsCorrectResult(double num1, double num2, double expectedResult)
        {
            var result = calculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }
    }

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


