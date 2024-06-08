using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Kolokwium.WpfApp.Windows;
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
            ShopDataGrid.DataContext = _dbContext.Shops;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetGrid(ShopDataGrid, _dbContext.Shops
                .Include(stud => stud.Products));
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

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ShopDataGrid.SelectedItem != null)
                if (ShopDataGrid.SelectedItem is Shop s)
                {
                    _dbContext.Shops.Remove(s);
                    _dbContext.SaveChanges();
                    SetGrid(ShopDataGrid, _dbContext.Shops.Include(stud => stud.Products));
                }
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (ShopDataGrid.SelectedItem != null && ShopDataGrid.SelectedItem is Shop s)
            {
                CreateWindow createWindow = new CreateWindow(_dbContext, s);
                if (createWindow.ShowDialog() ?? false)
                    SetGrid(ShopDataGrid, _dbContext.Shops.Include(stud => stud.Products));
            }
            else
            {
                CreateWindow createWindow = new CreateWindow(_dbContext, null);
                if (createWindow.ShowDialog() ?? false)
                    SetGrid(ShopDataGrid, _dbContext.Shops.Include(stud => stud.Products));
            }
            this.Show();
        }

        private void Button_Product_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            if (ShopDataGrid.SelectedItem != null && ShopDataGrid.SelectedItem is Shop s)
            {
                CreateProductWindow createWindow = new CreateProductWindow(_dbContext, s);
                if (createWindow.ShowDialog() ?? false)
                    SetGrid(ShopDataGrid, _dbContext.Shops.Include(stud => stud.Products));
            }
            this.Show();
        }
    }
}
