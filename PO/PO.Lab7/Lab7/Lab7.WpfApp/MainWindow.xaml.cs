using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7.WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainGrid.Children)
            {
                if (el is Button)
                {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
            {
                textLabel.Text = string.Empty;
            }
            else if (str == "C" && textLabel.Text.Length > 0)
            {
                textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
            }
            else if (str == "=")
            {
                try
                {
                    string? value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                }
                catch
                {
                    textLabel.Text = "Error!";
                }
            }
            else
            {
                if (textLabel.Text == "Error!" || textLabel.Text == "∞" || textLabel.Text == "-∞")
                {
                    return;
                }
                if (str == "-" && textLabel.Text.Length == 0)
                {
                    textLabel.Text += str;
                }
                if (IsOperator(str))
                {
                    if (textLabel.Text.Length == 0 || IsOperator(textLabel.Text.Last().ToString()))
                    {
                        return;
                    }
                }
                textLabel.Text += str;

                BTN_Equals.IsEnabled = !IsOperator(str);
            }
        }

        private bool IsOperator(string str)
        {
            return str == "+" || str == "-" || str == "*" || str == "/" || str == ".";
        }
    }
}