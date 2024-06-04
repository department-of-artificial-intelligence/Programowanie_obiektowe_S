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

namespace Kolokwium.WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Library _library;

        public AddBookWindow(ApplicationDbContext dbContext, Library library = null)
        {
            _dbContext = dbContext;
            DataContext = _library = library ?? new Library();
            InitializeComponent();
        }

        private void SaveBookButton_Click(object sender, RoutedEventArgs e)
        {
            var bookTitle = TitleTextBox.Text;
            var bookAuthor = AuthorTextBox.Text;

            var newBook = new Book
            {
                Title = bookTitle,
                Author = bookAuthor,
                LibraryId = _library.Id
            };
            _library.Books.Add(newBook);

            if (!_dbContext.Books.Contains(newBook))
                _dbContext.Books.Add(newBook);
            else
                _dbContext.Books.Update(newBook);

            _dbContext.SaveChanges();
            DialogResult = true;
        }
    }
}
