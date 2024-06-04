using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
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

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            SetGrid(DataGridLibrary, _dbContext.Libraries.Include(x => x.Books));
        }

        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> lista) where T : new()
        {
            dataGrid.Columns.Clear();
            var type= typeof(T);
            foreach (var prop in type.GetProperties())
                if(prop.GetCustomAttribute<HideAttribute>() == null)
                    dataGrid.Columns.Add(new DataGridTextColumn() { 
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                });
                dataGrid.AutoGenerateColumns = false;
                dataGrid.ItemsSource = lista;
                dataGrid.Items.Refresh();
        }

        private void AddEditLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditLibraryWindow addLibraryWindow;
            if(DataGridLibrary.SelectedItem != null && DataGridLibrary.SelectedItem is Library library) 
                addLibraryWindow = new AddEditLibraryWindow(_dbContext, library);
            else
                addLibraryWindow = new AddEditLibraryWindow(_dbContext);
            if(addLibraryWindow.ShowDialog() == true)
                SetGrid(DataGridLibrary, _dbContext.Libraries.Include(x => x.Books));
        }

        private void DeleteLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridLibrary.SelectedItem != null && DataGridLibrary.SelectedItem is Library library)
            {
                _dbContext.Libraries.Remove(library);
            }
            _dbContext.SaveChanges();
            SetGrid(DataGridLibrary, _dbContext.Libraries.Include(x => x.Books));
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow;
            if (DataGridLibrary.SelectedItem != null && DataGridLibrary.SelectedItem is Library library)
                addBookWindow = new AddBookWindow(_dbContext, library);
            else
                addBookWindow = new AddBookWindow(_dbContext);
            if (addBookWindow.ShowDialog() == true)
                SetGrid(DataGridLibrary, _dbContext.Libraries.Include(x => x.Books));
        }
    }
}
