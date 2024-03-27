using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.ComponentModel;
using System.Xml.Linq;
public class FinalGrade
{
	public Subject Subject { get; set; }
	public DateTime Date { get; set; }
	public double Value { get; set; }

	public FinalGrade(Subject subject, double value, DateTime date)
	{
		Subject = subject;
		Date = date;
		Value = value;
	}
    public override string ToString()
    {
        return $"Subject: {Subject}, Data: {Date}, Value: {Value}";
    }
}
