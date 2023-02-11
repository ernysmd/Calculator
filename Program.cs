using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator_refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            if (int.TryParse(input, out int operation) && operation >= 1 && operation <= 4)
            {
                Console.WriteLine("Enter 2 integers");
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();

                if (double.TryParse(number1, out double num1) && double.TryParse(number2, out double num2))
                {
                    double result = 0;
                    string operationString = "";
                    switch (operation)
                    {
                        case 1:
                            result = calculator.Add(num1, num2);
                            operationString = " + ";
                            break;
                        case 2:
                            result = calculator.Subtract(num1, num2);
                            operationString = " - ";
                            break;
                        case 3:
                            result = calculator.Multiply(num1, num2);
                            operationString = " * ";
                            break;
                        case 4:
                            result = calculator.Divide(num1, num2);
                            operationString = " / ";
                            break;
                    }
                    Console.WriteLine($"{number1}{operationString}{number2} = {result}");
                }
                else
                {
                    Console.WriteLine("One or more of the numbers is not a valid int");
                }
            }
            else
            {
                Console.WriteLine("Unknown input");
            }
        }
    }
}

