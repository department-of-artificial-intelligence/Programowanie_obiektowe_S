using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.APP
{
    public static class CalculatorCore
    {
        public static double CurrentValue { get; set; }
        public static string Add(string text)
        {
            CurrentValue += double.Parse(text);
            return CurrentValue.ToString();
        }
        public static string Sub(string text)
        {
            CurrentValue += double.Parse(text);
            return CurrentValue.ToString();
        }
        public static string Mul(string text)
        {
            CurrentValue += double.Parse(text);
            return CurrentValue.ToString();
        }
        public static string Div(string text)
        {
            CurrentValue += double.Parse(text);
            return CurrentValue.ToString();
        }
        public static void Clear() { CurrentValue = 0; }
    }
}
