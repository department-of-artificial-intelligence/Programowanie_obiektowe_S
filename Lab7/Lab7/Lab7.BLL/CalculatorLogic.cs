using System.Globalization;

namespace Lab7.BLL
{
    public class CalculatorLogic
    {
        private double _currentValue = 0;
        private double _memoryValue = 0;
        private string _currentOperator = "";
        private bool _isNewEntry = true;
        readonly CultureInfo _culture = CultureInfo.CurrentCulture;
        public string Display { get; private set; } = "0";

        public void EnterNumber(string digit)
        {
            // Handle decimal separator for both comma and dot input
            var sep = _culture.NumberFormat.NumberDecimalSeparator;
            if (digit == "," || digit == ".")
            {
                if (_isNewEntry)
                {
                    Display = "0" + sep;
                    _isNewEntry = false;
                }
                else if (!Display.Contains(sep))
                {
                    Display += sep;
                }
                return;
            }

            // Regular digit entry
            if (_isNewEntry)
            {
                Display = digit;
                _isNewEntry = false;
            }
            else
            {
                Display += digit;
            }
        }

        public void SetOperator(string op)
        {
            // Perform pending calculation if chaining operations
            if (!string.IsNullOrEmpty(_currentOperator) && !_isNewEntry)
            {
                Calculate();
            }
            // Parse display value according to current culture
            if (double.TryParse(Display, NumberStyles.Any, _culture, out var value))
            {
                _memoryValue = value;
                _currentOperator = op;
                _isNewEntry = true;
            }
        }

        public void Calculate()
        {
            if (string.IsNullOrEmpty(_currentOperator)) return;
            if (double.TryParse(Display, NumberStyles.Any, _culture, out var secondOperand))
            {
                switch (_currentOperator)
                {
                    case "+": _currentValue = _memoryValue + secondOperand; break;
                    case "-": _currentValue = _memoryValue - secondOperand; break;
                    case "*": _currentValue = _memoryValue * secondOperand; break;
                    case "/":
                        _currentValue = secondOperand == 0 ? double.NaN : _memoryValue / secondOperand;
                        break;
                }
                Display = _currentValue.ToString(_culture);
                _memoryValue = _currentValue;
                _isNewEntry = true;
                _currentOperator = string.Empty;
            }
        }

        public void Clear()
        {
            Display = "0";
            _currentValue = 0;
            _memoryValue = 0;
            _currentOperator = string.Empty;
            _isNewEntry = true;
        }

        public void Percentage()
        {
            if (double.TryParse(Display, NumberStyles.Any, _culture, out var value))
            {
                _currentValue = value / 100;
                Display = _currentValue.ToString(_culture);
                _memoryValue = _currentValue;
                _isNewEntry = true;
            }
        }
    }
}