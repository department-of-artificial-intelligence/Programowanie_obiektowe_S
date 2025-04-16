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

        int suma = 0;
        int temp = 0;

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }



        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button buttonPlus_Click)
            {
                if (suma == 0)
                {
                    suma = 0;
                }
                else
                {

                }
            }
        }
    }
}
