using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private string input = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                input += button.Content.ToString();
                Display.Text = input;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                input += $" {button.Content} ";
                Display.Text = input;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            input = "";
            Display.Text = "0";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(input, null);
                string resultString = result.ToString().Replace(',', '.');
                Display.Text = resultString;
                input = resultString;
            }
            catch
            {
                Display.Text = "Error";
                input = "";
            }
        }
    }
}