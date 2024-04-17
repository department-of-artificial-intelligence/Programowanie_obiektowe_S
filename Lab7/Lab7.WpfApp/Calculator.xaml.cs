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
        public Calculator()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, RoutedEventArgs e)
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

        private void button2_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void button3_Click(object sender, RoutedEventArgs e)
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

        private void button4_Click(object sender, RoutedEventArgs e)
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

        private void button5_Click(object sender, RoutedEventArgs e)
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

        private void button6_Click(object sender, RoutedEventArgs e)
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

        private void button7_Click(object sender, RoutedEventArgs e)
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

        private void button8_Click(object sender, RoutedEventArgs e)
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

        private void button9_Click(object sender, RoutedEventArgs e)
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

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            if (outbox.Text == "0" || outbox.Text == "")
            {
                outbox.Text = "0.";
            }
            else
            {
                outbox.Text += ".";
            }
        }
    }
}
