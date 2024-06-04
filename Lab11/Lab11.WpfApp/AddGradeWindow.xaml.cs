using Lab11.DAL.EF;
using Lab11.Model;
using Lab11.Model.Entities;
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

namespace Lab11.WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        private readonly Student _student;
        private readonly ApplicationDbContext _dbContext;
        public AddGradeWindow(ApplicationDbContext dbContext, Student student)
        {
            _dbContext = dbContext;
            _student = student;
            InitializeComponent();
        }

        private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxGrades.SelectedItem != null && ComboBoxGrades.SelectedItem is Grade grade &&
            Regex.IsMatch(TextBoxSubject.Text, @"^\p{L}{1,12}$"))
            {
                grade.Date = DateTime.Now;
                grade.Student = _student;
                grade.Subject = TextBoxSubject.Text;
                _dbContext.Grades.Add(grade);
                _dbContext.SaveChanges();
                DialogResult = true;
            }
            else
                MessageBox.Show("Invalid input data.");
        }

    }
}
