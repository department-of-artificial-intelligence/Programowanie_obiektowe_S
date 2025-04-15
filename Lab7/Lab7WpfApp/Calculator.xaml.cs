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

namespace Lab7WpfApp
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button1)
                OutPut.Text += "1";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button0)
                OutPut.Text += "0";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button2)
                OutPut.Text += "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button3)
                OutPut.Text += "3";
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button4)
                OutPut.Text += "4";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button5)
                OutPut.Text += "5";
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button6)
                OutPut.Text += "6";
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button7)
                OutPut.Text += "7";
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button8)
                OutPut.Text += "8";
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button9)
                OutPut.Text += "9";
        }
        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button buttonDot)
                OutPut.Text += ".";
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button C)
            {
                OutPut.Clear();
                OutPut.Text += "0";
            }
        }
        private void OutPut_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is Button button0)
                OutPut.Text += "0";
            if (sender is Button button1)
                OutPut.Text += "1";
            if (sender is Button button2)
                OutPut.Text += "2";
            if (sender is Button button3)
                OutPut.Text += "3";
            if (sender is Button button4)
                OutPut.Text += "4";
            if (sender is Button button5)
                OutPut.Text += "5";
            if (sender is Button button6)
                OutPut.Text += "6";
            if (sender is Button button7)
                OutPut.Text += "7";
            if (sender is Button button8)
                OutPut.Text += "8";
            if (sender is Button button9)
                OutPut.Text += "9";
            if (sender is Button buttonDot)
                OutPut.Text += ".";
            if (sender is Button C)
            {
                OutPut.Text += "0";
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
