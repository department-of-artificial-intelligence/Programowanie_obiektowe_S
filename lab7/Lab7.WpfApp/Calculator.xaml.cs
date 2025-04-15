using System.Windows;
using System.Windows.Controls;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private bool isClear = true;

        public Calculator()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            string buttonContent = clickedButton.Content.ToString();


            if (isClear)
            {
                tb.Text = buttonContent;
                isClear = false;
            }
            else
            {
                tb.Text += buttonContent;
            }


        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            string buttonContent = clickedButton.Content.ToString();

            if (buttonContent == "+" || buttonContent == "-" || buttonContent == "*" || buttonContent == "/")
            {
                string input = tb.Text;
                char separator = buttonContent[0];
                string[] parts = input.Split();
                string leftPart = parts[0];
                string rightPart = parts[1];
                operation(leftPart, rightPart, separator);
            }
            if (isClear)
            {
                tb.Text = buttonContent;
                isClear = false;
            }
            else
            {
                tb.Text += buttonContent;
            }


        }

        private void operation(string a, string b, char x)
        {
            double value;
            double ad;
            bool ab = double.TryParse(a, out ad);
            double bd;
            bool bb = double.TryParse(b, out bd);
            if (x == '+')
            {
                value = ad + bd;
                tb.Text = value.ToString();

            }
            else if (x == '-')
            {

            }
            else if (x == '*')
            {

            }
            else if (x == '-')
            {

            }
            else if (x == '=')
            {

            }
            else
            {
                tb.Text = "0";
                isClear = true;
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
