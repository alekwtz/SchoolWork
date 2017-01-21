using System;
using System.Collections.Generic;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        private CalculatorEngine calculator;

        [TestInitialize]
        public void SetUp()
        {
            calculator=new CalculatorEngine();
        }

        [TestMethod]
        public void Addition()
        {
            Input("1+2");
            AssertExpression("12+");
        }

        [TestMethod]
        public void AdditionThenMultiplication()
        {
            Input("1+2*3");
            AssertExpression("123*+");
        }

        [TestMethod]
        public void ComplexExpression()
        {
            Input("1+2*(3-7)/2-10");
            AssertExpression("1237-2/*10-+");
        }

        [TestMethod]
        public void Parenthesis()
        {
            Input("(1+2)*3");
            AssertExpression("12+3*");
        }

        [TestMethod]
        public void MultiplicationThenAddition()
        {
            Input("1*2+3");
            AssertExpression("12*3+");
        }

        private void Input(string expression)
        {
            foreach (var value in expression)
            {
                calculator.Input(value.ToString());
            } 
        }

        private void AssertExpression(string expected)
        {
            var actual = calculator.Evaluate();
            Assert.AreEqual(expected, string.Join("",actual));
        }
    }
}
