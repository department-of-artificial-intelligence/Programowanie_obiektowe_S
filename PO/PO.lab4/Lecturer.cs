using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;

public class Lecturer : Person
{
	public string AcademicTitle {  get; set; }
	public string Position {  get; set; }
	public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
	{
		AcademicTitle = academicTitle;
		Position = position;
	}
    public override string ToString()
    {
        return $"{base.ToString()} Academic Title: {AcademicTitle}, Position: {Position}";
    }
}
