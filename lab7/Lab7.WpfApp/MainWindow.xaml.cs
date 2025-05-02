using System;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace Lab7.WpfApp
{
    public partial class MainWindow : Window
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private Func<double, double, double> currentOperation = null;
        private bool isOperatorClicked = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonNumberClick(object sender, RoutedEventArgs e)
        {
            var clickedButton = sender as Button;
            string? value = clickedButton.Content.ToString();

            if (value == "," && display.Text.EndsWith(",")) return;

            if (!isOperatorClicked) //jezeli jest to pierwsza liczba
            {
                if (value == "," && display.Text.EndsWith(",")) return;


                if (display.Text == "0" && value != ",")
                {
                    display.Text = value;
                }
                else
                {
                    display.Text += value;
                }
            }

            else
            {
                if (value == "," && display.Text.EndsWith(",")) return;

                display.Text += value;
                isOperatorClicked = false;
            }

        }
        private void OnButtonOperationClick(object sender, RoutedEventArgs e)
        {
            var operation = (sender as Button).Content.ToString();
            var culture = new CultureInfo("pl-PL");
            if (double.TryParse(display.Text, NumberStyles.Any, culture, out firstNumber))
            {
                isOperatorClicked = true;
                display.Text += $" {operation} ";

                switch (operation)
                {
                    case "+":
                        currentOperation = (a, b) => a + b;
                        break;
                    case "-":
                        currentOperation = (a, b) => a - b;
                        break;
                    case "*":
                        currentOperation = (a, b) => a * b;
                        break;
                    case "/":
                        currentOperation = (a, b) => b == 0 ? throw new DivideByZeroException() : a / b;
                        break;
                }
            }
        }
        private void OnButtonResultClick(object sender, RoutedEventArgs e)
        {
            var culture = new CultureInfo("pl-PL");

            string[] parts = display.Text.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) return;

            string secondValue = parts[1].Trim();

            if (currentOperation != null && double.TryParse(secondValue, NumberStyles.Any, culture, out secondNumber))
            {
                try
                {
                    double result = currentOperation(firstNumber, secondNumber);
                    display.Text = result.ToString();
                    firstNumber = result;
                    isOperatorClicked = true;
                    secondValue = "";
                    currentOperation = null;
                }
                catch
                {
                    display.Text = "Error";
                }
            }

        }
        private void OnButtonClearClick(object sender, RoutedEventArgs e)
        {
            display.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = null;
            isOperatorClicked = false;
        }

    }
}