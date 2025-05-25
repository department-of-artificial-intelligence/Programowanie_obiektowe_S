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
        double cache = 0.0;
        int operation = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button0)
                if (!(OutPut.Text == "0"))
                    OutPut.Text += "0";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button1)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "1";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button2)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "2";
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button3)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "3";
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button4)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "4";
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button5)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "5";
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button6)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "6";
            }
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button7)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "7";
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button8)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "8";
            }
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button9)
            {
                if (OutPut.Text == "0")
                    OutPut.Clear();
                OutPut.Text += "9";
            }
        }
        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button buttonDot)
            {
                bool check = true;
                foreach (var i in OutPut.Text)
                {
                    if (i == '.')
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    string tmp = OutPut.Text + '.';
                    OutPut.Text = tmp;
                }
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button C)
            {
                OutPut.Clear();
                OutPut.Text += "0";
            }
        }
        /*private void OutPut_TextChanged(object sender, TextChangedEventArgs e)
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
        }*/

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Plus)
            {
                double tmp;
                if (!(double.TryParse(OutPut.Text, out tmp)))
                    OutPut.Text = "ERROR!";
                else
                {
                    if (operation == 0)
                    {
                        operation = 1;
                        cache = tmp;
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 1:
                                cache += tmp;
                                break;
                            case 2:
                                cache -= tmp;
                                break;
                            case 3:
                                cache *= tmp;
                                break;
                            case 4:
                                cache /= tmp;
                                break;
                        }
                    }
                    OutPut.Text = "0";
                }
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Minus)
            {
                double tmp;
                if (!(double.TryParse(OutPut.Text, out tmp)))
                    OutPut.Text = "ERROR!";
                else
                {
                    if (operation == 0)
                    {
                        operation = 2;
                        cache = tmp;
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 1:
                                cache += tmp;
                                break;
                            case 2:
                                cache -= tmp;
                                break;
                            case 3:
                                cache *= tmp;
                                break;
                            case 4:
                                cache /= tmp;
                                break;
                        }
                    }
                    OutPut.Text = "0";
                }
            }
        }

        private void Mul_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Mul)
            {
                double tmp;
                if (!(double.TryParse(OutPut.Text, out tmp)))
                    OutPut.Text = "ERROR!";
                else
                {
                    if (operation == 0)
                    {
                        operation = 3;
                        cache = tmp;
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 1:
                                cache += tmp;
                                break;
                            case 2:
                                cache -= tmp;
                                break;
                            case 3:
                                cache *= tmp;
                                break;
                            case 4:
                                cache /= tmp;
                                break;
                        }
                    }
                    OutPut.Text = "0";
                }
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Div)
            {
                double tmp;
                if (!(double.TryParse(OutPut.Text, out tmp)))
                    OutPut.Text = "ERROR!";
                else
                {
                    if (operation == 0)
                    {
                        operation = 4;
                        cache = tmp;
                    }
                    else
                    {
                        switch (operation)
                        {
                            case 1:
                                cache += tmp;
                                break;
                            case 2:
                                cache -= tmp;
                                break;
                            case 3:
                                cache *= tmp;
                                break;
                            case 4:
                                cache /= tmp;
                                break;
                        }
                    }
                    OutPut.Text = "0";
                }
            }
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Calc)
            {
                double tmp;
                if (!(double.TryParse(OutPut.Text, out tmp)))
                    OutPut.Text = "ERROR!";
                else
                {
                    switch (operation)
                    {
                        case 1:
                            cache += tmp;
                            break;
                        case 2:
                            cache -= tmp;
                            break;
                        case 3:
                            cache *= tmp;
                            break;
                        case 4:
                            cache /= tmp;
                            break;
                    }
                    operation = 0;
                    OutPut.Text = cache.ToString();
                }
            }
        }
    }
}
