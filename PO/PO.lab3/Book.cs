using System;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Numerics;
using System.Data;

public class Book : Item
{
	public int PageCount {  get; set; }
	public IList<Author> Authors {  get; set; }
	public Book()
	{
		PageCount = 0;
		Authors = new List<Author>();
	}
	public Book(string title, int id, string publisher, DateTime dateOfissue ,int pageCount, IList<Author> authors)
    {
        PageCount=pageCount;
        Authors=authors;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Page Count: {PageCount}, Authors: {Authors}";
    }
    public override string GenerateBarCode()
    {
        throw new NotImplementedException();
    }
}
