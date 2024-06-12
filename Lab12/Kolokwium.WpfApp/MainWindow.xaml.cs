using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;
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
            SetGrid(ParkDataGrid, _dbContext.Parks.Include(tree=>tree.Trees));
        }
        private void Add_Edit_Park_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Edit_Park add_Edit_Park;
            if (ParkDataGrid.SelectedItem != null && ParkDataGrid.SelectedItem is Park park)
                add_Edit_Park = new Add_Edit_Park(_dbContext, park);
            else
                add_Edit_Park = new Add_Edit_Park(_dbContext);
            if (add_Edit_Park.ShowDialog() == true)
                SetGrid(ParkDataGrid, _dbContext.Parks
                .Include(park => park.Trees));
        }
        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> data) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
                if (prop.GetCustomAttribute<HideAtributes>() == null)
                    dataGrid.Columns.Add(new DataGridTextColumn()
                    {
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                    });
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = data;
            dataGrid.Items.Refresh();
        }

        private void Delet_Park_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ParkDataGrid.SelectedItem != null)
            {
                if (ParkDataGrid.SelectedItem is Park p)
                {
                    _dbContext.Parks.Remove(p);
                    _dbContext.SaveChanges();
                    SetGrid(ParkDataGrid, _dbContext.Parks.Include(stud => stud.Trees));
                }
            }
        }

        private void Add_Edit_Tree_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Edit_Tree add_Edit_Tree;
            if (ParkDataGrid.SelectedItem != null && ParkDataGrid.SelectedItem is Park park)
                add_Edit_Tree = new Add_Edit_Tree(_dbContext, park);
            else
                add_Edit_Tree = new Add_Edit_Tree(_dbContext);
            if (add_Edit_Tree.ShowDialog() == true)
                SetGrid(ParkDataGrid, _dbContext.Parks
                .Include(park => park.Trees));
        }
    }   
}
