using System.Windows;
using System.Windows.Controls;
using Lab7.BLL;

namespace Lab7.WpfApp
{
    public partial class Calculator : Window
    {
        private CalculatorLogic _logic = new CalculatorLogic();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                _logic.EnterNumber(btn.Content.ToString());
                Display.Text = _logic.Display;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                _logic.SetOperator(btn.Content.ToString());
                Display.Text = _logic.Display;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            _logic.Calculate();
            Display.Text = _logic.Display;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _logic.Clear();
            Display.Text = _logic.Display;
        }

        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            _logic.Percentage();
            Display.Text = _logic.Display;
        }
    }
}
