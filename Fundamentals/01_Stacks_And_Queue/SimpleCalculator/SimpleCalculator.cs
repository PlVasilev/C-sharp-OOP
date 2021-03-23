using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var values = input.Split(' ');
            var calculatorStack = new Stack<string>(values.Reverse());

            while (calculatorStack.Count > 1)
            {
                int firstOperant = Int32.Parse(calculatorStack.Pop());
                string oprenad = calculatorStack.Pop();
                int secondOperand = Int32.Parse(calculatorStack.Pop());

                switch (oprenad)
                {
                    case "+":
                        calculatorStack.Push((firstOperant + secondOperand).ToString());
                        break;
                    case "-":
                        calculatorStack.Push((firstOperant - secondOperand).ToString());
                        break;
                    default:
                        calculatorStack.Push(0.ToString());
                        break;
                }
            }
            Console.WriteLine(calculatorStack.Pop());
        }
    }
}
