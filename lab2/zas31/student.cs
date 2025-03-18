using System;
using System.Net.NetworkInformation;

namespace lab3
{
	public class Student
	{
		public int year { get; set; }
		public int group { get; set; }
		public string id { get; set; }
		public Student() { }
		Student(int year, int group, string id)
		{
			this.year=year;
			this.group=group;
			this.id=id;
		}
		public override string ToString()
		{
			return $"brooo";
		}
		public void Details()
		{
			Console.WriteLine(this);
		}
	}
}
