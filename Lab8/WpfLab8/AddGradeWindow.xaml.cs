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

namespace WpfLab8.APP
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public double Value { get; set; }
        public AddGradeWindow()
        {
            InitializeComponent();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(input: TextBoxGrade.Text, pattern: @"^\d+\,\d{1,}$"))
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Value = double.Parse(TextBoxGrade.Text);
            Value = Math.Truncate(Value * 100) / 100;
            DialogResult = true;
        }
    }
}
