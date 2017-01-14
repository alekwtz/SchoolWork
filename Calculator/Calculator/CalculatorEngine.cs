
using System;

namespace Calculator
{
    class CalculatorEngine
    {
        private double result;
        private double input;

        public void Input(double number)
        {
            input = number;
        }

        public void Input(string operation)
        {
            switch (operation)
            {
                case "+":
                    result += input;
                    break;
                case "-":
                    result -= input;
                    break;
                case "*":
                    result *= input;
                    break;
                case "/":
                    result /= input;
                    break;
                case "sin(x)":
                    result = Math.Sin(result);
                    break;
            }
        }

        public double GetResult()
        {

            return result;

        }
    }
}
