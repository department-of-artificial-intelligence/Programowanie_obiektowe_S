using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Lab7.WpfApp.Modules;


namespace Lab7.WpfApp
{
    public partial class Calculator : Window
    {
        public double firstNumber = 0;
        public double secondNumber = 0;
        public string currentOperation = "";
        public bool isNewInput = true;

        public Calculator()
        {
            InitializeComponent();
            
        }

        public void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string number = button.Content.ToString();

            if (isNewInput)
            {
                CurrentDisplay.Text = number;
                isNewInput = false;
            }
            else
            {
                CurrentDisplay.Text += number;
            }
        }

        public void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            currentOperation = button.Content.ToString();

            firstNumber = double.Parse(CurrentDisplay.Text);
            HistoryDisplay.Text = $"{firstNumber} {currentOperation}";
            isNewInput = true;
        }

        public void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperation))
            {
                return;
            }

            secondNumber = double.Parse(CurrentDisplay.Text);

            if (secondNumber == 0)
            {
                return;
            }

            secondNumber = double.Parse(CurrentDisplay.Text);

            if (CalculatorModules.binaryOps.ContainsKey(currentOperation))
            {
                double result = CalculatorModules.binaryOps[currentOperation](firstNumber, secondNumber);
                CurrentDisplay.Text = result.ToString();
                HistoryDisplay.Text = $"{firstNumber} {currentOperation} {secondNumber} =";
                firstNumber = result;
                isNewInput = true;
            }
        }

        public void UnaryButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = double.Parse(CurrentDisplay.Text);
                var button = sender as Button;
                currentOperation = button.Content.ToString();

                if (CalculatorModules.unaryOps.ContainsKey(currentOperation))
                {
                    double result = CalculatorModules.unaryOps[currentOperation](number);

                    if (currentOperation == "sqrt(x)") HistoryDisplay.Text = $"sqrt({number})";
                    else if (currentOperation == "1/x") HistoryDisplay.Text = $"1/({number})";
                    else if (currentOperation == "Floor") HistoryDisplay.Text = $"Floor({number})";
                    else if (currentOperation == "x^2") HistoryDisplay.Text = $"x^({number})";


                    CurrentDisplay.Text = result.ToString();
                    isNewInput = true;
                }
            }
            catch (DivideByZeroException)
            {
                CurrentDisplay.Text = "Nie można dzielić przez zero";
                HistoryDisplay.Text = "";
                isNewInput = true;
            }
            catch (Exception ex)
            {
                CurrentDisplay.Text = "Błąd";
                HistoryDisplay.Text = ex.Message;
                isNewInput = true;
            }
        }

        public void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            HistoryDisplay.Text = "";
            CurrentDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
            isNewInput = true;
        }

        public void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            CurrentDisplay.Text = "0";
            isNewInput = true;
        }

        public void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentDisplay.Text.Length > 1)
            {
                CurrentDisplay.Text = CurrentDisplay.Text.Substring(0, CurrentDisplay.Text.Length - 1);
            }
            else
            {
                CurrentDisplay.Text = "0";
            }
        }


    }
}
