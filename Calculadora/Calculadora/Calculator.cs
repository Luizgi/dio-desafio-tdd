using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {
        private List<string> historic;

        public Calculator()
        {
            historic = new List<string>();  
        }


        public int Plus(int num1, int num2)
        {
            int result = num1 + num2;

            historic.Insert(0, "Result: " + result);
            return result;
        }

        public int Minus(int num1, int num2)
        {
            int result = num1 - num2;

            historic.Insert(0, "Result: " + result);
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;

            historic.Insert(0, "Result: " + result);
            return result;
        }

        public int Divide (int num1, int num2)
        {
            int result = num1 / num2;

            historic.Insert(0, "Result: " + result);
            return result;
        }

        public List<string> History()
        {
            historic.RemoveRange(3, historic.Count - 3);
            return historic;
        }

    }
}
