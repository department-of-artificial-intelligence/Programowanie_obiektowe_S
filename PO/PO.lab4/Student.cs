using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;

public class Student : Person
{
	static private int _id;
	public IList<FinalGrade> Grades { get; set; }
	public int Semester {  get; set; }
	public int Group {  get; set; }
	public int IndexId { get; set; }
	public string Specialization {  get; set; }
	public double AverageGrades { get; }
	public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
	{
		Specialization = specialization;
		Group = group;
		Semester = semester;
		IndexId = _id++;
	}
    public override string ToString()
    {
        return $"{base.ToString()}, Specialization: {Specialization}, group: {Group}, semester: {Semester}";
    }
}
