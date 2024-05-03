using System.Windows;
using System.Windows.Controls;

namespace Lab07.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public double value1;
        public double result;
        public char op;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Btn)
                PropText.Text += Btn.Content;
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            if (sender is Button Btn)
                PropText.Text = "";
            result = 0;
            value1 = 0;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 'a';
        }
        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 's';
        }

        private void Button_Mul(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 'm';
        }

        private void Button_Div(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 'd';
        }

        private void Button_Solve(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 'a':
                    result = value1 + double.Parse(PropText.Text);
                    PropText.Text = result.ToString();
                    break;

                case 's':
                    result = value1 - double.Parse(PropText.Text);
                    PropText.Text = result.ToString();
                    break;
                case 'm':
                    result = value1 * double.Parse(PropText.Text);
                    PropText.Text = result.ToString();
                    break;
                case 'd':
                    result = value1 / double.Parse(PropText.Text);
                    PropText.Text = result.ToString();
                    break;
            }
        }
    }
}
