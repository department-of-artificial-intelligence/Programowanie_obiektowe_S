using Lab09.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab09.App.PopUpWindows
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public AddGradeWindow()
        {
            InitializeComponent();
        }
        public int Value = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(ValueTextBox.Text, @"^[2-5]{1}$")){
                MessageBox.Show("Invalid data.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Value = Convert.ToInt32(ValueTextBox.Text);
            DialogResult = true;
        }
    }
}
