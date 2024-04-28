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
    /// Logika interakcji dla klasy AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; set; }

        public AddStudentWindow(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                outbox_f.Text = student.Faculty;
                outbox_fn.Text = student.FirstName;
                outbox_sn.Text = student.SurName;
                outbox_st.Text = student.StudentNo.ToString();
            }
            Student = student ?? new Student();
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(input: outbox_fn.Text, pattern: @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: outbox_sn.Text, pattern: @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: outbox_f.Text, pattern: @"^\p{L}{1,12}$") ||
               !Regex.IsMatch(input: outbox_st.Text, pattern: @"^[0-9]{4,10}$"))
            {
                MessageBox.Show(messageBoxText: "Invalid input data");
                return;
            }

            Student.FirstName = outbox_fn.Text;
            Student.SurName = outbox_sn.Text;
            Student.Faculty = outbox_f.Text;
            Student.StudentNo = int.Parse(outbox_st.Text);
            DialogResult = true;
        }
    }
}
