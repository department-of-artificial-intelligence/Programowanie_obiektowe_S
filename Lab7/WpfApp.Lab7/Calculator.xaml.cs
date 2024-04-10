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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp.Lab7
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private double a;
        private double b;
        private string action;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_Dot_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_Equal_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            
        }

        private void Button_Sum_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
            action = "+";
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_Multy_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }

        private void Button_Dev_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Screen.Text += button.Content;
            }
        }
    }
}
