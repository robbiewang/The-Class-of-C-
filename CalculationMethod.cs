using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class CalculationMethod
    {
        private static int result = 0;

        public int Add(int number1, int number2)
        {
            result = number1 + number2;
            return result;
        }

        public int Subtraction(int number1, int number2)
        {
            result = number1 - number2;
            return result;
        }

        public int Multiplication(int number1, int number2)
        {
            result = number1 * number2;
            return result;
        }

        public int Division(int number1, int number2)
        {
            result = number1 / number2;
            return result;
        }
        public int remainder(int number1,int number2)
            {
            result = number1 % number2;
            return result;

            }
        
            public int Bitwise(int number1, int number2)
        {
            result = number1 &number2;
            return result;

        }

    }
}
