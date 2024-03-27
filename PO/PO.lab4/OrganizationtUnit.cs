using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;

public class OrganizationUnit
{
	public string Name {  get; set; }
	public string Address {  get; set; }
	public IList<Lecturer> Lecturers { get; set; }

	public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
	{
		Name = name;
		Address = address;
		Lecturers = lecturers;
	}
    public override string ToString()
    {
		string a = $"Name: {Name}, Address: {Address}, ";
		foreach(var l in Lecturers)
		{
			a += l.ToString();
		}
        return a;
    }
}
