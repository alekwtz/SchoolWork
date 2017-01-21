
using System;
using System.Collections.Generic;

namespace Calculator
{
    public class CalculatorEngine
    {
        private readonly List<string> input = new List<string>();
        
        public void Input(string data)
        {
            input.Add(data);
        }

        public List<string> Evaluate()
        {
            Stack<string> operators=new Stack<string>();
            List<string> output = new List<string>();

            foreach (var data in input)
            {
                if (IsNumber(data))
                {
                    output.Add(data);
                }
                else if(data=="(")
                {
                   operators.Push(data); 
                }
                else if (data == ")")
                {
                    var operatorsInsideParantheses = GetOperatorsUntil("(", operators);
                    output.AddRange(operatorsInsideParantheses);
                }
                else
                {
                    var higherPriority = GetHigherPriority(operators, data);
                    if (higherPriority.Count > 0)
                    {
                        output.AddRange(higherPriority);
                    }
                    operators.Push(data);
                }
            }
            while (operators.Count>0)    
            {
                output.Add(operators.Pop());
            }
            return output;
        }

        private List<string> GetHigherPriority(Stack<string>operators,string toCompare )
        {
            List<string> result= new List<string>();
            while (operators.Count>0)
            {
                var lastOperator = operators.Peek();

                if (HasHigherPriority(toCompare, lastOperator))
                {
                    return result;
                }
                result.Add(lastOperator);
                operators.Pop();
            }
            return result;
        }

        private bool HasHigherPriority(string a, string b )
        {
            string priority = "+-*/";
            int indexA = priority.IndexOf(a);
            int indexB = priority.IndexOf(b);
            return indexA > indexB;
        }

        private bool IsNumber(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }

        private List<string> GetOperatorsUntil(string value, Stack<string>operators)
        {
            List<string> result=new List<string>();

            while (true)
            {
               var  lastOperator = operators.Pop();
                if (lastOperator==value)
                {
                    return result;
                }
                result.Add(lastOperator);
            }
        } 
        
        public double GetResult()
        {

            return 0;

        }
    }
}
