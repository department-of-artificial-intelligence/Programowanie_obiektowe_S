using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model.Entities
{
	public class Car
	{
		public int Id { get; set; }
		public string Model { get; set; } = null!;
		public DateTime DateOfParking { get; set; } = DateTime.Now;
		public Parking Parking { get; set; } = null!;
		public override string ToString()
		{
			return Model + " " + DateOfParking;
		}
	}
}
