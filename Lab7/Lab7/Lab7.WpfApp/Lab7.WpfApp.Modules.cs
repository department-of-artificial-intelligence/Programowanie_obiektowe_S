using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.WpfApp.Modules
{
    public static class CalculatorModules
    {
        // Słownik operacji dwuargumentowych
        public static readonly Dictionary<string, BinaryOperation> binaryOps = new()
        {
            { "+", (a, b) => a + b },
            { "-", (a, b) => a - b },
            { "*", (a, b) => a * b },
            { "/", (a, b) => b != 0 ? a / b : throw new DivideByZeroException() }
        };

        // Słownik operacji jednoargumentowych
        public static readonly Dictionary<string, UnaryOperation> unaryOps = new()
        {
            { "sqrt(x)", a => Math.Sqrt(a) },
            { "1/x", a => a != 0 ? 1 / a : throw new DivideByZeroException() },
            { "x^2", a => a * a },
            { "Floor", a => Math.Floor(a)},
            { "+/-", a => -a}
        };
    }

    // Delegaty do operacji
    public delegate double BinaryOperation(double a, double b);
    public delegate double UnaryOperation(double a);
}
