using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	public class Car
	{
		private static int _carCount = 0;
		private string _brand;
		private int _doorCount;
		private double _engineVolume;
		private double _avgConsump;

		public string Brand
		{
			get { return _brand; }
			set { _brand = value; }
		}
		public int DoorCount
		{ get { return _doorCount; } set { _doorCount = value; } }
		public double EngineVolume
		{ get { return _engineVolume; } set { _engineVolume = value; } }


	}
}



