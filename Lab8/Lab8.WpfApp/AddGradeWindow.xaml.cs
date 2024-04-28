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
    /// Logika interakcji dla klasy AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public AddGradeWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(input: outbox_value.Text, pattern: @"^[0-9]+\,[0-9]{1}$") ||
                !Regex.IsMatch(input: outbox_subject.Text, pattern: @"^\p{L}{1,15}$"))
            {
                MessageBox.Show(messageBoxText: "Invalid input data");
                return;
            }
            DialogResult = true;
        }
    }
}
