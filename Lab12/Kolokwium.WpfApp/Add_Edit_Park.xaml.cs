using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kolokwium.WpfApp
{
    /// <summary>
    /// Interaction logic for Add_Edit_Park.xaml
    /// </summary>
    public partial class Add_Edit_Park : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Park? _park;
        public Add_Edit_Park(ApplicationDbContext dbContext, Park park = null)
        {
            _dbContext = dbContext;
            DataContext = _park = park ?? new Park();
            InitializeComponent();
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextBoxName.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxCity.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(TextBoxArea.Text, @"^[0-9]{1,10}$")
                )
            {
                MessageBox.Show("Invalid data");
                return;
            }
            if (_park == null)
            {
                _park = new Park();
                _park.Name = TextBoxName.Text;
                _park.City = TextBoxCity.Text;
                _park.Area = Int32.Parse(TextBoxArea.Text);
                _dbContext.Parks.Add(_park);
                _dbContext.SaveChanges();
            }
            else
            {
                _park.Name = TextBoxName.Text;
                _park.City = TextBoxCity.Text;
                _park.Area = Int32.Parse(TextBoxArea.Text);
                _dbContext.SaveChanges();
            }
            if (!_dbContext.Parks.Contains(_park))
                _dbContext.Parks.Add(_park);
            _dbContext.SaveChanges();
            DialogResult = true;
        }
    }
}
