using Lab10.DAL.EF;
using Lab10.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

namespace Lab10.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        private readonly Student _student;
        private readonly ApplicationDbContext _dbContext;
        public AddGradeWindow(ApplicationDbContext dbContext, Student student)
        {
            _dbContext = dbContext;
            DataContext = _student = student ?? new Student();
            InitializeComponent();
            ComboBoxGrade.ItemsSource = _dbContext.Grades.Local.ToObservableCollection();
            _dbContext.Grades.Load();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxGrade.SelectedItem != null && ComboBoxGrade.SelectedItem is Grade grade)
            {
                grade.Date = DateTime.Now;
                grade.Student = _student;
                grade.Subject = SubjectTextBox.Text;
                _dbContext.Grades.Add(grade);
                _dbContext.SaveChanges();
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Invalid input data");
            }
        }
    }
}
