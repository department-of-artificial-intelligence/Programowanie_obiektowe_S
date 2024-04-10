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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 1;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 2;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 3;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 4;
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 5;
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 6;
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 7;
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 8;
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += 9;
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if ((textBox.Text == "/0"))
            {
                textBox.Clear();
            }
            textBox.Text += 0;
        }
        private void Button_ClickDot(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text != string.Empty)
                {
                    textBox.Text += ".";
                }
            }
        }
        private void Button_ClickC(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
    }
}
