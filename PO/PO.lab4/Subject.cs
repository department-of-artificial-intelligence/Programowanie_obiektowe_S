using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;

public class Subject
{
	public string Name {  get; set; }
	public string Specialization { get; set; }
	public int Semester {  get; set; }
	public int HoursCount {  get; set; }
	public Subject(string name, string specialization, int semester, int hourscount) 
	{
		Name = name;
		Specialization = specialization;
		Semester = semester;	
		HoursCount = hourscount;
	}
    public override string ToString()
    {
        return $"Name of subject: {Name}, Specialization: {Specialization}, Semester: {Semester}, Hour count: {HoursCount}";
    }
}
