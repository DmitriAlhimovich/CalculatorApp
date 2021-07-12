using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input number1:");
            var operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input operation (+, -, *, /):");
            var operation = Console.ReadLine()[0];

            Console.WriteLine("Input number2:");
            var operand2 = double.Parse(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;

                case '-':
                    result = operand1 - operand2;
                    break;

                case '*':
                    result = operand1 * operand2;
                    break;

                case '/':
                    result = operand1 / operand2;
                    break;

                default:
                    throw new ArgumentException($"Operation not supported: {operation}");
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}
