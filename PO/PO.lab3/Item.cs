using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.Data;

public abstract class Item
{
	protected int _id;
	protected string _title;
	protected string _publisher;
	protected DateTime _dateOfissue;

	public int Id
	{
		get => _id;
		set => _id = value;
	}
	public string Title
	{
		get => _title;
		set => _title = value;
	}
	public string Publisher
	{
		get => _publisher;
		set => _publisher = value;
	}
	public DateTime DateOfissue
	{
		get => _dateOfissue; 
		set => _dateOfissue = value;
	}
	public Item()
	{
		_id = 0;
		_title = "-";
		_publisher = "-";
		_dateOfissue = DateTime.MinValue;
	}
	public Item(int id, string title, string publisher, DateTime dateOfissue)
    {
        _id=id;
        _title=title;
        _publisher=publisher;
        _dateOfissue=dateOfissue;
    }
    public override string ToString()
    {
        return $"id: {_id}, title: {_title}, publisher: {_publisher}, date of issue: {_dateOfissue}";
    }
	public void Details()
	{
		Console.WriteLine(this.ToString());
	}
	public abstract string GenerateBarCode();
}
