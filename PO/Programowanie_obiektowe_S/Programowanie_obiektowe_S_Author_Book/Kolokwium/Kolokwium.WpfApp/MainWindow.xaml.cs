using Kolokwium.DAL.EF;
using Kolokwium.Model;
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
            DataGridAuthor.DataContext = _dbContext;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetGrid(DataGridAuthor, _dbContext.Authors.Include(b => b.Books));
        }

        private void AddEditAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditAuthorWindow addEditAuthorWindow;
            if (DataGridAuthor.SelectedItem != null && DataGridAuthor.SelectedItem is Author author)
            {
                addEditAuthorWindow = new AddEditAuthorWindow(_dbContext, author);
            }
            else
            {
                addEditAuthorWindow = new AddEditAuthorWindow(_dbContext);
            }
            if (addEditAuthorWindow.ShowDialog() == true)
            {
                SetGrid(DataGridAuthor, _dbContext.Authors.Include(b => b.Books));
            }
        }

        private void AddEditBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditBookWindow addEditBookWindow;
            if (DataGridAuthor.SelectedItem != null && DataGridAuthor.SelectedItem is Author author)
            {
                addEditBookWindow = new AddEditBookWindow(_dbContext, author);
            }
            else
            {
                addEditBookWindow = new AddEditBookWindow(_dbContext);
            }
            if (addEditBookWindow.ShowDialog() == true)
            {
                SetGrid(DataGridAuthor, _dbContext.Authors.Include(b => b.Books));
            }
           
        }

        private void DeleteAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridAuthor.SelectedItem != null && DataGridAuthor.SelectedItem is Author author)
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
                SetGrid(DataGridAuthor, _dbContext.Authors.Include(b => b.Books));
            }
        }

        

        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                {
                    dataGrid.Columns.Add(new DataGridTextColumn()
                    {
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                    });
                }

            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = list;
            dataGrid.Items.Refresh();
        }

        
    }
}
