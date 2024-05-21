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

namespace PO.lab07.App
{
    /// <summary>
    /// Interaction logic for Calclulator.xaml
    /// </summary>
    public partial class Calclulator : Window
    {
        public Calclulator()
        {
            InitializeComponent();
        }

        private void bt_0_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button bt_0)
            {
                bt_0.Content += textbox_wpisz.Text;
            }
        }
    }
}
