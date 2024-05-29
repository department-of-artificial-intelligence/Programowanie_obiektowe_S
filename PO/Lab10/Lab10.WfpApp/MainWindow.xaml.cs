﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Lab10.DAL.EF;
using Lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;


namespace Lab10.WfpApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        // Wstrzykiwanie zależności kontekstu do klasy Main Window (DI, Dependency Injection)
        public MainWindow(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetGrid(DataGridStudents, _dbContext.Students
            // ladowanie danych powiazanych przy pomocy Eager Loading.
            .Include(stud => stud.Grades));
        }
        private void ButtonAddEditStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            AddEditStudentWindow addStudentWindow;
            if (DataGridStudents.SelectedItem != null && DataGridStudents.SelectedItem is Student student)
                addStudentWindow = new AddEditStudentWindow(_dbContext, student);
            else
                addStudentWindow = new AddEditStudentWindow(_dbContext);
            if (addStudentWindow.ShowDialog() == true)
                SetGrid(DataGridStudents, _dbContext.Students
                .Include(stud => stud.Grades));
        }

        private void ButtonRemoveStudentWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student studentToRemove)
            {
                dbContext.Students.Remove(studentToRemove);
                _dbContext.SaveChanges();
                SetGrid(DataGridStudents, _dbContext.Students
                .Include(stud => stud.Grades));
            }
        }
        private void ButtonAddGradeWindowShow_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null && DataGridStudents.SelectedItem is Student selectedStudent)
            {
                var addGradeWindow = new AddGradeWindow(_dbContext, selectedStudent);
                if (addGradeWindow.ShowDialog() == true)
                    SetGrid(DataGridStudents, _dbContext.Students
                    .Include(stud => stud.Grades));
            }
            else
                MessageBox.Show("Select student.");
        }
        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                    dataGrid.Columns.Add(new DataGridTextColumn()
                    {
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                    });
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = list;
            dataGrid.Items.Refresh();
        }
    }






}





}