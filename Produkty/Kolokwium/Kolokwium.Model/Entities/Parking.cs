using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium.Model.Attributes;

namespace Kolokwium.Model.Entities
{
	public class Parking
	{
		public int Id { get; set; }
		public string Adress { get; set; } = null!;
		public int ParkingLotsCount { get; set; }
		public DateTime DateOfBuilding { get; set; }

		[Hide]
		public IList<Car> Cars { get; set; } = null!;
		public string AllCars => Cars.Count > 0 ? string.Join(", ", Cars) : "";
	}
}
