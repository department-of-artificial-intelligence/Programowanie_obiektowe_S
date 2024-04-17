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

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public double res=0;
        public char sgn='0';
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "0";
            }
            else
            {
                outbox.Text += "0";
            }
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "1";
            }
            else
            {
                outbox.Text += "1";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "2";
            }
            else
            {
                outbox.Text += "2";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "3";
            }
            else
            {
                outbox.Text += "3";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "4";
            }
            else
            {
                outbox.Text += "4";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "5";
            }
            else
            {
                outbox.Text += "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "6";
            }
            else
            {
                outbox.Text += "6";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "7";
            }
            else
            {
                outbox.Text += "7";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "8";
            }
            else
            {
                outbox.Text += "8";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text = "9";
            }
            else
            {
                outbox.Text += "9";
            }
        }

        private void btndot_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0")
            {
                outbox.Text += ".";
            }
            else
            {
                outbox.Text += ".";
            }
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            outbox.Text = "0";
            res = 0;
            sgn = '0';
        }

        private void btnsum_Click(object sender, RoutedEventArgs e)
        {
            res=Int32.Parse(outbox.Text);
            sgn = '+';
            outbox.Text = "0";
        }

        private void btnfin_Click(object sender, RoutedEventArgs e)
        {
            if (sgn == '+')
            {
                res += Int32.Parse(outbox.Text);
                outbox.Text = res.ToString();
            }
            else if(sgn == '-'){
                res -= Int32.Parse(outbox.Text);
                outbox.Text = res.ToString();
            }
            else if(sgn == '/')
            {
                res /= Int32.Parse(outbox.Text);
                outbox.Text = res.ToString();
            }
            else if (sgn == '*')
            {
                res *= Int32.Parse(outbox.Text);
                outbox.Text = res.ToString();
            }
        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            res = Int32.Parse(outbox.Text);
            sgn = '-';
            outbox.Text = "0";
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            res = Int32.Parse(outbox.Text);
            sgn = '*';
            outbox.Text = "0";
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            res = Int32.Parse(outbox.Text);
            sgn = '/';
            outbox.Text = "0";
        }
    }
}
