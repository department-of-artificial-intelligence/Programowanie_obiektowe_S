using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.BLL
{
    public class Calculator_Operation
    {
        public double operation_Add(double x, double y)
        { 
            return x + y;
        }
        public double operation_Sub(double x, double y)
        { 
            return x - y;
        }
        public double operation_Mul(double x, double y)
        {
            return x * y;
        }
        public double operation_Div(double x, double y)
        {
            return (x / y);
        }
    }
}
