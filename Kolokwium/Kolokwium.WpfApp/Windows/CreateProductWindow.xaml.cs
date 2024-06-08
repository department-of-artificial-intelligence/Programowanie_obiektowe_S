using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for CreateProductWindow.xaml
    /// </summary>
    public partial class CreateProductWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Shop shop;
        public CreateProductWindow(ApplicationDbContext dbContext, Shop shop)
        {
            _dbContext = dbContext;
            InitializeComponent();
            this.shop = shop;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price = 0;
            if (!String.IsNullOrEmpty(NameTextBox.Text) &&
                !String.IsNullOrEmpty(DescriptionTextBox.Text) &&
                !String.IsNullOrEmpty(PriceTextBox.Text)&&
                double.TryParse(PriceTextBox.Text,out price))
            {
                    Product p = new Product();
                    p.Name = NameTextBox.Text;
                    p.Description = DescriptionTextBox.Text;
                    p.Price = price;
                    shop.Products.Add(p);
                    _dbContext.SaveChanges();
            }
            DialogResult = true;
        }
    }
}
