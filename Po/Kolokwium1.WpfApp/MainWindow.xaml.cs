using Kolokwium1.DAL.EF;
using Kolokwium1.MODEL.Entities;
using Lab10.Model;
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

namespace Kolokwium1.WpfApp
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
        private void Window_Loaded(object sender,RoutedEventArgs e)
        {
            SetGrid(DataGridClient, _dbContext.Clients.Include(stud => stud.Books));
        }

        private static void SetGrid<T>(DataGrid grid, IEnumerable<T> list) where T : new() 
        {
            grid.Columns.Clear();
            var type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                {
                    grid.Columns.Add(new DataGridTextColumn() { Header = prop.Name, Binding = new Binding(prop.Name) });

                }
            }
            grid.AutoGenerateColumns = false;
            grid.ItemsSource = list;
            grid.Items.Refresh();
        }

        private void AddOrEditClient_Click(object sender, RoutedEventArgs e)
        {
            AddOrEditClient addOrEditClient;
            if (DataGridClient != null && DataGridClient.SelectedItem is Client client)
            {
                addOrEditClient = new AddOrEditClient(_dbContext, client);

            }
            else
            {
                addOrEditClient = new AddOrEditClient(_dbContext);
                
            }
            
            if (addOrEditClient.ShowDialog() == true)
                SetGrid(DataGridClient, _dbContext.Clients.Include(stud => stud.Books));

        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridClient != null && DataGridClient.SelectedItem is Client client)
            { 
                _dbContext.Clients.Remove(client);
                _dbContext.SaveChanges();
                SetGrid(DataGridClient, _dbContext.Clients.Include(stud => stud.Books));
            }
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow;
            
           addBookWindow = new AddBookWindow(_dbContext);
               
            //if(addBookWindow.ShowDialog()==true)
            //{
            //    SetGrid(DataGridClient, _dbContext.Clients.Include(stud => stud.Books));
            //}
        }
    }
}