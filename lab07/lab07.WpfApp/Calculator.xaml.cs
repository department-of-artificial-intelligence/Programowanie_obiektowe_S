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

namespace lab07.WpfApp
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

        private void ButtonNuber(object sender, RoutedEventArgs e)
        {
            if (sender is Button Buttonx) 
            {
                TextBlock.Text += Buttonx.Content;
            }
        }

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = " ";
        }
    }
}
