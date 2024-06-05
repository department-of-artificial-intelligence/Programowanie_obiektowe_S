using Lab10.DAL.EF;
using Lab10.Model;
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

namespace Lab10.WpfApp
{
    /// <summary>
    /// Interaction logic for AddOrEditStudent.xaml
    /// </summary>
    public partial class AddOrEditStudent : Window
    {
        private readonly Student _student;
        private readonly ApplicationDbContext _context;
        public AddOrEditStudent(ApplicationDbContext dbContext, Student? student=null)
        {
            _context = dbContext;
            DataContext = _student = student ?? new Student();
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(ImieTextBlock.Text, @"^\p{Lu}{1,12}\p{Ll}{1,12}$")
            || !Regex.IsMatch(NazwiskoTextBlock.Text, @"^\p{L}{1,12}$")
            || !Regex.IsMatch(FacultyTextBlock.Text, @"^\p{L}{1,12}$")
            || !Regex.IsMatch(IndeksTextBlock.Text, @"^[0-9]{4,10}$") ||
                !DataPickerDateOfBirth.SelectedDate.HasValue)
            {
                MessageBox.Show("Invalid Data");
                return;
            }
            if (!_context.Students.Contains(_student))
                _context.Students.Add(_student);
            else 
                _context.Students.Update(_student);
            _context.SaveChanges();
            DialogResult = true;
        }
    }
}
