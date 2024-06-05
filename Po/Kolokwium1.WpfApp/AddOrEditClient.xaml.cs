using Kolokwium1.DAL.EF;
using Kolokwium1.MODEL.Entities;
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

namespace Kolokwium1.WpfApp
{
    /// <summary>
    /// Interaction logic for AddOrEditClient.xaml
    /// </summary>
    public partial class AddOrEditClient : Window
    {
        private readonly Client? _client;
        private readonly ApplicationDbContext _dbContext;
        public AddOrEditClient(ApplicationDbContext dbContext, Client? client=null)
        {
            InitializeComponent();
            _dbContext = dbContext;
            DataContext = _client = client ?? new Client();
            ComboBoxBooks.ItemsSource = _dbContext.Books.Local.ToObservableCollection();
            _dbContext.Books.Load();
        }

        private void AddOrEdit_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(FirstNameTextBox.Text, @"^\p{Lu}{1,12}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(SurNameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(AddressTextBox.Text, @"^\p{L}{1,12}$") ||
                !DateOfBirthDataPicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Invalid data");
                return;
            }
            if (_client != null)
            {
                // Tworzymy obiekt książki, do którego przypiszemy wybraną książkę lub nowo utworzoną
                Book book = new Book();
                if (ComboBoxBooks.SelectedItem != null && ComboBoxBooks.SelectedItem is Book selectedBook)
                {
                    book = selectedBook;
                }

                // Sprawdź, czy klient istnieje w bazie danych
                if (!_dbContext.Clients.Contains(_client))
                {
                    // Dodaj klienta do kontekstu bazy danych
                    _dbContext.Clients.Add(_client);
                }
                else
                {
                    // Jeśli klient istnieje, zaktualizuj go w kontekście bazy danych
                    
                    _dbContext.Clients.Update(_client);
                }

                // Dodaj książkę do listy książek klienta
                //_client.Books.Add(book);
                // Zapisz zmiany w bazie danych
                _client.Books.Add(book);
                _dbContext.SaveChanges();

                DialogResult = true;
            }

            
        }

        private void ComboBoxBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        public Book ReturnBook()
        {
            Book b = new Book();
            if (ComboBoxBooks.SelectedItem != null && ComboBoxBooks.SelectedItem is Book selectedBook)
            {
                // Dodaj wybraną książkę do kolekcji książek klienta, jeśli jeszcze jej tam nie ma

                b = selectedBook;
                
            }
             return b;
        }
    }
}
