using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.Data;

public class Journal : Item
{
	public int Number
	{
		get;
		set;
	}

	public Journal()
	{
		Number = 0;
	}
	public Journal(string title, int id, string publisher,DateTime dateofissue, int number) 
	{
		_title = title;
		_id = id;
		_publisher = publisher;
		_dateOfissue = dateofissue;
		Number = number;
	}
	public override string ToString()
	{
		return $"{base.ToString()}, Number {Number}";
	}
    public override string GenerateBarCode()
    {
        Random rnd = new Random();
        return $"{rnd.Next(1000, 9999)}";
    }
}
