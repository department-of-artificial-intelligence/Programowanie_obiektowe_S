using Kolokwium.DAL.EF;
using Kolokwium.Model.Attributes;
using Kolokwium.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kolokwium.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;

        public MainWindow(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
            InitializeComponent();

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

        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
                if(prop.GetCustomAttribute<HideAttribute>() == null)
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
