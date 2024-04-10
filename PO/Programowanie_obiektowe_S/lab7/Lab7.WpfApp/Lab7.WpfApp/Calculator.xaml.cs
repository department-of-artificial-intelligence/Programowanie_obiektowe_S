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
        double rezult = 0; 
        string str = string.Empty;

        public Calculator()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button){
                TextBox.Text += button.Content;
            }
            
                
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TextBox.Text += button.Content;
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TextBox.Text += button.Content;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TextBox.Text += button.Content;
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                TextBox.Text += button.Content;
                
            }
            
        }

    }
}
