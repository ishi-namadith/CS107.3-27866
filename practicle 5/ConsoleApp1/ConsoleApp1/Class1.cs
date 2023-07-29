using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CalculateValues
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            if (num1>num2)
            {
                return num1 / num2;
            }
            else
            {
                return num2 / num1;
            }
        }

    }
}
