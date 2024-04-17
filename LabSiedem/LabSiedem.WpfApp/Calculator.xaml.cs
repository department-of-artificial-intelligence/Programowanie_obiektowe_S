using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
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

namespace LabSiedem.WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        float result, num1;
        int operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "0";
            }
            else
            {
                outbox.Text += "0";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "1";
            }
            else
            {
                outbox.Text += "1";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "2";
            }
            else
            {
                outbox.Text += "2";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "3";
            }
            else
            {
                outbox.Text += "3";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "4";
            }
            else
            {
                outbox.Text += "4";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "5";
            }
            else
            {
                outbox.Text += "5";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "6";
            }
            else
            {
                outbox.Text += "6";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "7";
            }
            else
            {
                outbox.Text += "7";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "8";
            }
            else
            {
                outbox.Text += "8";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "9";
            }
            else
            {
                outbox.Text += "9";
            }
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "" || outbox.Text == null)
            {
                outbox.Text = "0,";
            }
            else
            {
                outbox.Text += ",";
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            outbox.Focus();
            operation = 1;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if(outbox.Text != "")
            {
                num1 = float.Parse(outbox.Text);
                outbox.Clear();
                outbox.Focus();
                operation = 2;
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            outbox.Focus();
            operation = 3;
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            outbox.Focus();
            operation = 4;
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 4)
            {
                result = num1 * float.Parse(outbox.Text);
                outbox.Text = result.ToString();
            }
            else if (operation == 3)
            {
                result = num1 / float.Parse(outbox.Text);
                outbox.Text = result.ToString();
            }
            else if (operation == 2)
            {
                result = num1 - float.Parse(outbox.Text);
                outbox.Text = result.ToString();
            }
            else if (operation == 1)
            {
                result = num1 + float.Parse(outbox.Text);
                outbox.Text = result.ToString();
            }

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            operation = '0';
            outbox.Text = "0";
        }
    }
}
