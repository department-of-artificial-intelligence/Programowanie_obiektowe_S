using Kolokwium1.DAL.EF;
using Kolokwium1.MODEL.Entities;
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

namespace Kolokwium1.WpfApp
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        private readonly Client? _client;
        private readonly ApplicationDbContext _dbContext;
        public AddBookWindow(ApplicationDbContext dbContext, Client? client=null)
        {
            InitializeComponent();
            _dbContext = dbContext;
            DataContext = _client = client ?? new Client();
            ComboBoxBook.ItemsSource = _dbContext.Books.Local.ToObservableCollection();
            _dbContext.Books.Load();
        }

        private void ComboBoxBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxBook.SelectedItem != null && ComboBoxBook.SelectedItem is Book book)
            {
                book.Title = TitleTextBox.Text;
                book.Author = AuthorTextBox.Text;
                book.Cost = Double.Parse(CostTextBox.Text);
                book.CClient = _client;
                book.DataWydania = DateTime.Now;
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                DialogResult = true;
            }
            else {
                MessageBox.Show("Input Valid");
            }
        }
    }
}
