using System;
using System.Linq;

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your simple math expression to calculate, eg: 23+454-34+34*33/7");
            string operation = Console.ReadLine();
            double result = 0;
            string currentNumber = "";
            char currentOperator = '+';
            
            for (int i = 0; i <= operation.Length; i++)
            {
                if (i == operation.Length || "+-*/".Contains(operation[i]))
                {
                    if (!double.TryParse(currentNumber, out double number))
                    {
                        Console.WriteLine("Invalid number: " + currentNumber);
                        return;
                    }
                    switch (currentOperator)
                    {
                        case '+':
                            result += number;
                            break;
                        case '-':
                            result -= number;
                            break;
                        case '*':
                            result *= number;
                            break;
                        case '/':
                            if (number == 0)
                            {
                                Console.WriteLine("Division by zero error");
                                return;
                            }
                            result /= number;
                            break;
                    }
                    if (i < operation.Length)
                    {
                        currentOperator = operation[i];
                    }
                    currentNumber = "";
                }
                else
                {
                    currentNumber += operation[i];
                }
            }
            Console.WriteLine("Result is: {0}", result);
        }
    }
}
