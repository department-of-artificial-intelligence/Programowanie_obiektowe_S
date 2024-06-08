using Kolokwium.DAL.EF;
using Kolokwium.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kolokwium.WpfApp.Windows
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Shop shop;
        public CreateWindow(ApplicationDbContext dbContext,Shop _shop=null)
        {
            _dbContext = dbContext;
            InitializeComponent();
            shop = _shop;
            if (shop != null )
            {
                this.DataContext = shop;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(NameTextBox.Text)&&
                !String.IsNullOrEmpty(AddressTextBox.Text) &&
                !String.IsNullOrEmpty(CityTextBox.Text))
            {
                if (shop == null)
                {
                    shop=new Shop();
                    shop.Name = NameTextBox.Text;
                    shop.Address = AddressTextBox.Text;
                    shop.City = CityTextBox.Text;
                    _dbContext.Shops.Add(shop);
                    _dbContext.SaveChanges();
                }
                else
                {
                    shop.Name = NameTextBox.Text;
                    shop.Address = AddressTextBox.Text;
                    shop.City = CityTextBox.Text;
                    _dbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("WRONG DATA!!");
            }
            DialogResult = true;
        }
    }
}
