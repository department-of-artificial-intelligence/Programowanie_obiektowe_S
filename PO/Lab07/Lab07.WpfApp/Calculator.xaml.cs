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

namespace Lab07.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public double value1;
        public double value2;
        public char op;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Btn)
                PropText.Text += Btn.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            if (sender is Button Btn)
                PropText.Text = "";
            value2 = 0;
            value1 = 0;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 'a';
        }
        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(PropText.Text);
            PropText.Text = "";
            op = 's';
        }
        private void Button_Solve(object sender, RoutedEventArgs e)
        {
            value2 = double.Parse(PropText.Text);
            if (op == 'a')
            {
                PropText.Text = (value1 + value2).ToString();
            }
            if (op == 's')
            {
                PropText.Text = (value1 - value2).ToString();
            }
            
        }
    }
}
