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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TextBox.Text += button.Content;
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if(!string.IsNullOrEmpty(TextBox.Text))
                { 
                    TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length -1);
                }
            }
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {

        }

        private void odejmij(object sender, RoutedEventArgs e)
        {

        }

        private void sub(object sender, RoutedEventArgs e)
        {

        }

        private void div(object sender, RoutedEventArgs e)
        {

        }

        private void clear(object sender, RoutedEventArgs e)
        {

        }

        private void final(object sender, RoutedEventArgs e)
        {

        }
    }
}
