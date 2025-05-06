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

namespace Lab7.APP
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public bool ToRefresh = false;
        public string Text = "0";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button )
            {
                switch (Button.Content)
                {
                    case "+":
                        Text = CalculatorCore.Add(Text);
                        ToRefresh = true;
                        break;
                    case "-":
                        Text = CalculatorCore.Sub(Text);
                        ToRefresh = true;
                        break;
                    case "*":
                        Text = CalculatorCore.Mul(Text);
                        ToRefresh = true;
                        break;
                    case "/":
                        Text = CalculatorCore.Div(Text);
                        ToRefresh = true;
                        break;
                    case "C":
                        Text = "0";
                        break;
                    default:
                        if (Text == "0" || ToRefresh)
                        {
                            Text = String.Empty;
                            ToRefresh = false;
                        }
                        Text += Button.Content;
                        break;
                }
            }
            TextBar.Text = Text;
        }
    }
}
