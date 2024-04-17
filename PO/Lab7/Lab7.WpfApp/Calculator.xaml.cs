using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button ButtonOk) 
            {
                TextBoxName.Text+=ButtonOk.Content;
            }
            
        }

        private void Usuwam(object sender, RoutedEventArgs e)
        {
            if (sender is Button ButtonOk)
            {
                TextBoxName.Text = string.Empty;
            }

        }
       

    }
}
