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

namespace lab77.WpfApp
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

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is Button one)
                pole.Text += one.Content; 

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button zero)
                pole.Text += zero.Content;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button two)
                pole.Text += two.Content;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button three)
                pole.Text += three.Content;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button four)
                pole.Text += four.Content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button five)
                pole.Text += five.Content;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button six)
                pole.Text += six.Content;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button seven)
                pole.Text += seven.Content;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button eight)
                pole.Text += eight.Content;
        }

        private void nine_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button nine)
                pole.Text += nine.Content;

        }
    }
}
