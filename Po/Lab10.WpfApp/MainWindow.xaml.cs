using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab10.Model;
using Microsoft.VisualBasic;
using Lab10.DAL.EF;
namespace Lab10.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        public MainWindow(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetGrid(DataGridStudents, _dbContext.Students.Include(stud => stud.Grades));
        }



        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
        { 
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
            {
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                {
                    dataGrid.Columns.Add(new DataGridTextColumn() { Header = prop.Name, Binding = new Binding(prop.Name) });

                }
            }
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = list;
            dataGrid.Items.Refresh();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem != null && DataGridStudents.SelectedItem is Student student)
            {
                var addGradeWindow = new AddGradeWindow(_dbContext, student);
                if (addGradeWindow.ShowDialog() == true)
                    SetGrid(DataGridStudents, _dbContext.Students.Include(stud => stud.Grades));
            }
            else
                MessageBox.Show("Select student");
        }

        private void AddOrEditStudent_Click(object sender, RoutedEventArgs e)
        {
            AddOrEditStudent addStudentWindow;
            if (DataGridStudents.SelectedItem != null && DataGridStudents.SelectedItem is Student student)
                addStudentWindow = new AddOrEditStudent(_dbContext, student);
            else 
                addStudentWindow = new AddOrEditStudent(_dbContext);
            if (addStudentWindow.ShowDialog() == true)
            {
                SetGrid(DataGridStudents, _dbContext.Students.Include(stod => stod.Grades));
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student student)
            { 
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
                SetGrid(DataGridStudents, _dbContext.Students.Include(stud => stud.Grades));
            }
        }
    }
}