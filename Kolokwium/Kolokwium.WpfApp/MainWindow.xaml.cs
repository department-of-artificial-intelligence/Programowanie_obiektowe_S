using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Kolokwium.WpfApp.Commands;
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
using Kolokwium.WpfApp.Extensions;

namespace Kolokwium.WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        public ICommand DeleteShopCommand { get; }
        public ICommand AddEditShopCommand { get; }
        public ICommand AddProductCommand { get; }

        public MainWindow(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
            InitializeComponent();
            ShopDataGrid.DataContext = _dbContext.Shops;

            //Commands
            ButtonsGrid.DataContext = this;
            DeleteShopCommand = new DeleteShopCommand(_dbContext, ShopDataGrid);
            AddEditShopCommand = new AddEditShopCommand(_dbContext, ShopDataGrid,this.Hide,this.Show);
            AddProductCommand = new AddProductCommand(_dbContext, ShopDataGrid, this.Hide, this.Show);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShopDataGrid.SetGrid(_dbContext.Shops
                .Include(stud => stud.Products));
        }
    }
}
