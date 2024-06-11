using Kolokwium.DAL.EF;
using Kolokwium.Model.Entities;
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
	/// Логика взаимодействия для AddEditParkingWindow.xaml
	/// </summary>
	public partial class AddEditParkingWindow : Window
	{
		private readonly ApplicationDbContext _dbContext;
		private readonly Parking? _parking;
		public AddEditParkingWindow(ApplicationDbContext dbContext, Parking parking = null)
		{
			_dbContext = dbContext;
			DataContext = _parking = parking ?? new Parking();
			InitializeComponent();
		}

		private void ButtonSaveParking_Click(object sender, RoutedEventArgs e)
		{
			if (!Regex.IsMatch(TextBoxAdress.Text, @"^\p{Lu}{1,12}\p{Ll}{1,12}$") ||
				!Regex.IsMatch(TextBoxParkingLotsCount.Text, @"^[0-9]{1,5}$") ||
				!DatePickerDateOfBuilding.SelectedDate.HasValue)
			{
				MessageBox.Show("Invalid data");
				return;
			}

			if (!_dbContext.Parkings.Contains(_parking)) // sprawdzenie czy encja istnieje w kontekscie
				_dbContext.Parkings.Add(_parking); // dodanie encji do kontekstu
			else
				_dbContext.Parkings.Update(_parking); // modyfikacja encji w kontekscie
			_dbContext.SaveChanges(); // wygenerowanie SQL oraz wykonanie go na bazie danych
			DialogResult = true;
		}
	}
}
