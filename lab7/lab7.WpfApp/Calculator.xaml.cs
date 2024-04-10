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

namespace lab7.WpfApp
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

        private void Buttom_0_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_4_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_6_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_dode_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                Textbox.Text += button.Content;
        }

        private void Buttom_C_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
              Textbox.Text = ;
        }
    }
}
