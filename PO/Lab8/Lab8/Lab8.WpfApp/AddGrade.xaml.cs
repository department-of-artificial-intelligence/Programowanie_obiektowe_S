using Lab8.BLL;
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

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGrade.xaml
    /// </summary>
    public partial class AddGrade : Window
    {
        public double Value { get; set; }
        public AddGrade()
        {
            InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TB_Grade.Text, @"^\d+\,\d{1,}$"))
            {
                MessageBox.Show("Invalid Input Data");
                return;
            }
            Value = double.Parse(TB_Grade.Text);
            Value = Math.Truncate(Value * 100) / 100;
            DialogResult = true;
        }
    }
}
