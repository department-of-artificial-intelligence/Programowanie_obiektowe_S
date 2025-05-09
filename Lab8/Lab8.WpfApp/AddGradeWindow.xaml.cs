using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Lab8.BLL;

namespace Lab8.WpfApp
{
    public partial class AddGradeWindow : Window
    {
        public Grade NewGrade { get; private set; }
        public AddGradeWindow()
        {
            InitializeComponent();
        }
        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSubject.Text) ||
                !double.TryParse(TextBoxScore.Text, out double score) || score < 2.0 || score > 5.0)
            {
                MessageBox.Show("Invalid input. Please ensure the score is between 2.0 and 5.0 and subject is not empty.");
                return;
            }
            NewGrade = new Grade(TextBoxSubject.Text, score, DatePickerGradeDate.SelectedDate ?? DateTime.Now);
            DialogResult = true;
        }
    }
}