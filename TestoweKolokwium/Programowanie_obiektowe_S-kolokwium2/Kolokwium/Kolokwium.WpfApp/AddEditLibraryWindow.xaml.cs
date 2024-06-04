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
    /// Logika interakcji dla klasy AddEditLibraryWindow.xaml
    /// </summary>
    public partial class AddEditLibraryWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Library _library;
        public AddEditLibraryWindow(ApplicationDbContext dbContext, Library library = null)
        {
            _dbContext = dbContext;
            DataContext = _library = library ?? new Library();
            InitializeComponent();
        }

        private void SaveLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            if(!_dbContext.Libraries.Contains(_library)) 
            {
                _dbContext.Libraries.Add(_library);
            }
            else
            {
                _dbContext.Libraries.Update(_library);
            }
            _dbContext.SaveChanges();
            DialogResult = true;
        }
    }
}
