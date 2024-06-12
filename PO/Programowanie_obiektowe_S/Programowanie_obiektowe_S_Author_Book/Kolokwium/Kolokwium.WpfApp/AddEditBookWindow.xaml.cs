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
    /// Interaction logic for AddEditBookWindow.xaml
    /// </summary>
    public partial class AddEditBookWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Author? _author;
        public AddEditBookWindow(ApplicationDbContext dbContext, Author author = null)
        {
            _dbContext = dbContext;
            InitializeComponent();
            _author = author;
        }

        private void SaveAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxTitle.Text) && !string.IsNullOrEmpty(TextBoxGenre.Text)){
                if(_author != null)
                {
                    Book _book = new Book();
                    _book.Title = TextBoxTitle.Text;
                    _book.Genre = TextBoxGenre.Text;
                    _book.Author = _author;
                    _dbContext.Books.Add(_book);
                    _dbContext.SaveChanges();


                }
                
                DialogResult = true;
            }
        }
    }
}
