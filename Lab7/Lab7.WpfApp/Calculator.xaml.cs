using System.Data;
using System.Windows;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { textBox.Text += "1"; }

        private void Button_Click_2(object sender, RoutedEventArgs e) { textBox.Text += "2"; }

        private void Button_Click_3(object sender, RoutedEventArgs e) { textBox.Text += "3"; }

        private void Button_Click_4(object sender, RoutedEventArgs e) { textBox.Text += "4"; }

        private void Button_Click_5(object sender, RoutedEventArgs e) { textBox.Text += "5"; }

        private void Button_Click_6(object sender, RoutedEventArgs e) { textBox.Text += "6"; }

        private void Button_Click_7(object sender, RoutedEventArgs e) { textBox.Text += "7"; }

        private void Button_Click_8(object sender, RoutedEventArgs e) { textBox.Text += "8"; }

        private void Button_Click_9(object sender, RoutedEventArgs e) { textBox.Text += "9"; }

        private void Button_Click_0(object sender, RoutedEventArgs e) { textBox.Text += "0"; }

        private void Button_Click_Dot(object sender, RoutedEventArgs e) { textBox.Text += ","; }

        private void Button_Click_Plus(object sender, RoutedEventArgs e) { textBox.Text += "+"; }

        private void Button_Click_Minus(object sender, RoutedEventArgs e) { textBox.Text += "-"; }

        private void Button_Click_Mul(object sender, RoutedEventArgs e) { textBox.Text += "*"; }

        private void Button_Click_Div(object sender, RoutedEventArgs e) { textBox.Text += "/"; }

        private void Button_Click_Clear(object sender, RoutedEventArgs e) { textBox.Clear(); }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            string tmp = textBox.Text;

            textBox.Text = new DataTable().Compute(tmp, null).ToString();
        }
    }
}
