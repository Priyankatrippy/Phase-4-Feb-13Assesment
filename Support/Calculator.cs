using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Support
{
    public class Calculator
    {
        private int _num1;
        private int _num2;

        public void EnterNumber(int number)
        {
            if (_num1 == 0)
                _num1 = number;
            else
                _num2 = number;
        }

        public int Multiply()
        {
            return _num1 * _num2;
        }

    }
    
}
