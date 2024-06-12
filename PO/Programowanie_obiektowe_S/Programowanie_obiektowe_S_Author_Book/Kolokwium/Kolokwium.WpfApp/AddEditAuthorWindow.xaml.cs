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
    /// Interaction logic for AddEditAuthorWindow.xaml
    /// </summary>
    public partial class AddEditAuthorWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Author? _author;
        public AddEditAuthorWindow(ApplicationDbContext dbContext, Author author = null)
        {
            _dbContext = dbContext;
            InitializeComponent();
            _author = author;
        }

        private void SaveAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(TextBoxFirstName.Text) &&  !string.IsNullOrEmpty(TextBoxLastName.Text) && !string.IsNullOrEmpty(TextBoxEmail.Text) && TextBoxEmail.Text.Contains("@"))
            //Regex.IsMatch(TextBoxMaxIntCar.Text, @"^[0-9]{4,10}$
            //DatePickerDateOfBirth.SelectedDate.HasValue
            {
                if (_author == null)
                {
                    _author = new Author();
                    _author.FirstName = TextBoxFirstName.Text;
                    _author.LastName = TextBoxLastName.Text;
                    _author.Email = TextBoxEmail.Text;
                    //_parking.MaxInt = Int32.Parse(TextBoxMaxInt.Text);
                    _dbContext.Authors.Add(_author);
                    _dbContext.SaveChanges();
                }
                else
                {
                    _author.FirstName = TextBoxFirstName.Text;
                    _author.LastName = TextBoxLastName.Text;
                    _author.Email = TextBoxEmail.Text;
                }
            }
            else
            {
                MessageBox.Show("Check Data");
            }
            DialogResult = true;
        }
    }
}
