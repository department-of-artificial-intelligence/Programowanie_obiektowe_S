using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace Lab7.WbfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private string value;
        private string output;
        private double first;
        private int dot = 0;

        private Func<double, double, double> operation;
        public Calculator()
        {
            InitializeComponent();
            output = "";
            value = "";
            first = 0.0;
            operation = Nah;
        }

        private double Add(double x, double y) { return x + y; }
        private double Substract(double x, double y) { return x - y; }
        private double Multiply(double x, double y) { return x * y; }
        private double Divide(double x, double y) { return x / y; }
        private double Nah(double x, double y) { return 0.0; }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string button_content = (string)((Button)sender).Content;

            if (button_content == "." && value == "")
            {
                value = "0";
                output += "0";
            }

            if (button_content == ".")
            {
                button_content = ",";
                ++dot;
                if (dot >= 2 )
                    return;
            }

            value += button_content;
            output += button_content;
            TextBoxName.Text = output;
        
        }

     

        private void Button_Click_Operation(object sender, RoutedEventArgs e)
        {
            output += (string)((Button)sender).Content;
            switch ((string)((Button)sender).Content)
            {

                case "+":
                    operation = Add;
                    break;
                case "-":
                    operation = Substract;
                    break;
                case "/":
                    operation = Divide;
                    break;
                case "*":
                    operation = Multiply;
                    break;
                case "C":
                    output = value  =  "0";
                    break;
                default:
                    break;

            }
            if(double.TryParse(value, out var val))
            {
                first = val;
            }
            dot = 0;
            value = "";
            TextBoxName.Text = output;
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(value, out var val))
            {
                output = value = operation(first, val).ToString();
            }
            dot = 0;
            TextBoxName.Text = output;

        }
    }
}
