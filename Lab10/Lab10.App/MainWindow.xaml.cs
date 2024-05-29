using Lab10.DAL;
using Lab10.Model.Attributes;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Lab10.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MSContext _db;
        public MainWindow(MSContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
            {
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                {
                    dataGrid.Columns.Add(new DataGridTextColumn()
                    {
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                    });
                }
            }
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = list;
            dataGrid.Items.Refresh();
        }
    }
}