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

namespace Lab7.BBL {
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window {
        public Calculator() {
            InitializeComponent();
        }
        static double liczba = 0;

        private void PobierzLiczbe(object sender, RoutedEventArgs e) {
            if(sender is Button button) {
                Wynik.Text += button.Content;
            }
        }
    }
}
