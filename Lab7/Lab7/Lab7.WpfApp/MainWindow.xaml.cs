using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string output;
        private double first;
        private Func<double, double, double> operation;
        public MainWindow()
        {
            InitializeComponent();
            output = "0";
            first = 0.0;
            operation = Nah;
        }

        private double Add(double x, double y) { return x + y; }
        private double Substract(double x, double y) { return x - y; }
        private double Multiply(double x, double y) { return x * y; }
        private double Divide(double x, double y) { return x / y; }
        private double Nah(double x, double y) { return 0.0; }

        private void RefreshTextBox()
        {
            TextBoxName.Text = output;
        }

        private void Button_Click_Number(object sender, RoutedEventArgs e)
        {
            string content = (string)((Button)sender).Content;
            if (double.Parse(output) == 0 && content != ",")
            {
                output = content;
            }
            else
            {
                output += content;
            }
            RefreshTextBox();
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            output = operation(first, double.Parse(output)).ToString();
            RefreshTextBox();
        }

        private void Button_Click_Operation(object sender, RoutedEventArgs e)
        {
            string content = (string)((Button)sender).Content;
            switch (content)
            {
                case "+":
                    operation = Add;
                    break;
                case "-":
                    operation = Substract;
                    break;
                case "*":
                    operation = Multiply;
                    break;
                case "/":
                    operation = Divide;
                    break;
                case "C":
                    output = "0";
                    break;
                default:
                    break;
            }
            first = double.Parse(output);
            output = "0";
            RefreshTextBox();
        }

        
    }
}
