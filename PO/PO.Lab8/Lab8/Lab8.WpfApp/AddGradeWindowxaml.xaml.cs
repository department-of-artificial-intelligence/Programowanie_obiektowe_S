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

    public partial class AddGradeWindowxaml : Window
    {
        public Grade Grade {  get; set; }
        public AddGradeWindowxaml(Grade? grade = null)
        {
            InitializeComponent();
            if(grade != null)
            {
                textBox_Grade.Text = grade.Value.ToString();
            }
            Grade = grade ?? new Grade();
        }

        private void BTN_AddG_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(textBox_Grade.Text, @"^[2-5](\,[05])?$"))
            {
                MessageBox.Show("Invalid value 1!");
                return;
            }
            if (!double.TryParse(textBox_Grade.Text, out double grade))
            {
                MessageBox.Show("Invalid value 2!");
                return;
            }
            if (grade < 2.0 || grade > 5.0)
            {
                MessageBox.Show("Invalid value 3!");
                return;
            }
            Grade.Value = grade;
            DialogResult = true;
        }
    }
}
