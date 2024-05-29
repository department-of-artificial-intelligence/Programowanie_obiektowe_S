using Lab10.DAL.EF;
using Lab10.Model.Entities;
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

namespace Lab10.APP.PopUpWindows
{
    public partial class AddEditStudentWindow : Window
    {
        private readonly Student _student;
        private readonly ApplicationDbContext _dbContext;
        private bool is_new = false;    
        public AddEditStudentWindow(ApplicationDbContext dbContext, Student student=null)
        {
            _dbContext = dbContext;
            _student = student??new Student();
            if(student==null)
                is_new = true;
            InitializeComponent();
            this.DataContext= _student;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(SurnameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(FacultyTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(IndexTextBox.Text, @"^[0-9]{4,10}$")||
                BirthDatePicker.SelectedDate==null
                )
            {
                MessageBox.Show("Invalid data.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            _student.FirstName = NameTextBox.Text;
            _student.SurName = SurnameTextBox.Text;
            _student.Faculty = FacultyTextBox.Text;
            _student.DateOfBirth= (DateTime)BirthDatePicker.SelectedDate;    
            _student.StudentIndex = Convert.ToInt32(IndexTextBox.Text);
            if (is_new)
                _dbContext.Students.Add(_student);
            else
                _dbContext.Students.Update(_student);
            _dbContext.SaveChanges();
            DialogResult = true;
        }
    }
}
