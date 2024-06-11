using Kolokwium.DAL.EF;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kolokwium.Model.Attributes;
using Microsoft.EntityFrameworkCore;
using Kolokwium.Model.Entities;

namespace Kolokwium.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _dbContext;

        public MainWindow(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
            InitializeComponent();

        }
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			SetGrid(DataGridParkings, _dbContext.Parkings
			// ladowanie danych powiazanych przy pomocy Eager Loading.
			.Include(park => park.Cars));
		}

		private void AddOrEditParkingButtonClick(object sender, RoutedEventArgs e)
		{
			AddEditParkingWindow addParkingWindow;
			if (DataGridParkings.SelectedItem != null && DataGridParkings.SelectedItem is Parking parking)
				addParkingWindow = new AddEditParkingWindow(_dbContext, parking);
			else
				addParkingWindow = new AddEditParkingWindow(_dbContext);
			if (addParkingWindow.ShowDialog() == true)
				SetGrid(DataGridParkings, _dbContext.Parkings
				.Include(park => park.Cars));
		}
		private static void SetGrid<T>(DataGrid dataGrid, IEnumerable<T> list) where T : new()
		{
			dataGrid.Columns.Clear();
			var type = typeof(T);
			foreach (var prop in type.GetProperties())
				if (prop.GetCustomAttribute<HideAttribute>() == null)
					dataGrid.Columns.Add(new DataGridTextColumn()
					{
						Header = prop.Name,
						Binding = new Binding(prop.Name)
					});
			dataGrid.AutoGenerateColumns = false;
			dataGrid.ItemsSource = list;
			dataGrid.Items.Refresh();
		}

		private void DeleteParkingButtonClick(object sender, RoutedEventArgs e)
		{
			if (DataGridParkings.SelectedItem != null && DataGridParkings.SelectedItem is Parking parking)
			{
				_dbContext.Parkings.Remove(parking);
				_dbContext.SaveChanges();
				SetGrid(DataGridParkings, _dbContext.Parkings.Include(park => park.Cars));
			}
		}

		private void AddCarButtonClick(object sender, RoutedEventArgs e)
		{
			if (DataGridParkings.SelectedItem != null && DataGridParkings.SelectedItem is Parking parking)
			{
				AddCarWindow addCarWindow = new AddCarWindow(_dbContext, null, parking);
				if (addCarWindow.ShowDialog() == true)
				{
					SetGrid(DataGridParkings, _dbContext.Parkings.Include(park => park.Cars).ToList());
				}
			}
		}

	}
}
