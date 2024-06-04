using Lab11.DAL.EF;
using Lab11.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab11.WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy AddEditStudentWindow.xaml
    /// </summary>
    public partial class AddEditStudentWindow : Window
    {
        public Student student;
        private ApplicationDbContext dbContext;
        private readonly ApplicationDbContext _dbContext;

        public AddEditStudentWindow(ApplicationDbContext dbContext, Student _student)
        {
            _dbContext = dbContext;
            student = _student;
            InitializeComponent();
        }

        public AddEditStudentWindow(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private void ButtonSaveStudent_Click(object sender, RoutedEventArgs e)
        {  
            student.FirstName = TextBoxFirstName.Text;
            student.SurName = TextBoxSurName.Text;
            student.Faculty = TextBoxFaculty.Text;
            student.StudentIndex = int.Parse(TextBoxStudentIndex.Text);
            student.DateOfBirth = DatePickerDateOfBirth.SelectedDate.Value;
            DialogResult = true;
        }
    }
}
