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
        public char znak;
        public double x;
        public Calculator()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            znak = '+';
            x =  Convert.ToDouble(textinout.Text.Trim());
            textinout.Clear();
        }
        
        private void rownasie_Click(object sender, RoutedEventArgs e)
        {
            double z;
            double y = Convert.ToDouble(textinout.Text.Trim());
            textinout.Clear();
            switch (znak)
            {
                case '+':
                    z = x + y;
                    textinout.TextInput;
                    break;
            }
            
        }
    }
}
