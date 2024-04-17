
namespace lab7.BLL
{
    using System;
    public class Calculator
    {
        private double _result;
        private string _txtNumber;
        public double Result => _result;
        public string TxtNumber => _txtNumber;
        public Calculator()
        {
            _result = 0.0;
            _txtNumber = string.Empty;
        }
        public void TypeInNum(char ch)
        {
            _txtNumber += ch;
        }


    }

}
