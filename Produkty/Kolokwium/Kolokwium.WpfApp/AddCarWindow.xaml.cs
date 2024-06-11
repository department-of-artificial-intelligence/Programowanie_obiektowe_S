using Kolokwium.DAL.EF;
using Kolokwium.Model.Entities;
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
	/// Логика взаимодействия для AddCarWindow.xaml
	/// </summary>
	public partial class AddCarWindow : Window
	{
		private readonly ApplicationDbContext _dbContext;
		private readonly Car _car;
		private readonly Parking _parking;

		public AddCarWindow(ApplicationDbContext dbContext, Car car = null, Parking parking = null)
		{
			_dbContext = dbContext;
			_car = car ?? new Car();
			_parking = parking;
			DataContext = _car;
			InitializeComponent();
		}

		private void ButtonSaveCar_Click(object sender, RoutedEventArgs e)
		{
			if (!Regex.IsMatch(TextBoxModel.Text, @"^\p{L}{1,12}$") ||
				!DatePickerDateOfParking.SelectedDate.HasValue)
			{
				MessageBox.Show("Invalid data");
				return;
			}

			_car.Model = TextBoxModel.Text;
			_car.DateOfParking = DatePickerDateOfParking.SelectedDate.Value;

			if (_parking != null)
			{
				if (_parking.Cars == null)
				{
					_parking.Cars = new List<Car>();
				}

				_parking.Cars.Add(_car);

				if (!_dbContext.Parkings.Contains(_parking))
				{
					_dbContext.Parkings.Add(_parking);
				}
				else
				{
					_dbContext.Parkings.Update(_parking);
				}
			}

			if (!_dbContext.Cars.Contains(_car))
			{
				_dbContext.Cars.Add(_car);
			}
			else
			{
				_dbContext.Cars.Update(_car);
			}

			_dbContext.SaveChanges();
			DialogResult = true;
		}
	}
}
