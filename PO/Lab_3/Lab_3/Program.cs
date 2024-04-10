using System;
using System.Data;
using System.Globalization;
using System.Collections.Generic;

abstract class Item {

    protected int _id;
    protected string _title;
    protected string _publisher;
    protected DateTime _dateOfIssue;

    public int Id {

        get { return _id; }
        set { _id = value; }

    }

    public string Title {

        get { return _title; }
        set { _title = value; }

    }

    public string Publisher {

        get { return _publisher; }
        set { _publisher = value; }

    }

    public DateTime DateOfIssue {

        get { return _dateOfIssue; }
        set { _dateOfIssue = value; }

    }

    public Item()
    {
        _id = 0;
        _title = "none";
        _publisher = "none";
        _dateOfIssue = DateTime.Now;


    }

    public Item(string title, int id, string publisher, DateTime dateOfIssue) {
    
        _id=id;
        _title = title;
        _publisher = publisher;
        _dateOfIssue = dateOfIssue;
    
    }

    public override string ToString()
    {
        return $"Item | id {_id}, Title {_title}, Publisher {_publisher}, DateOfIssue, {_dateOfIssue}";
    }


    public void Details() {

        Console.WriteLine(ToString());

    }

  /*  public string GenerateBarCode()
    {

        int codeLength = 12;
        Random random = new Random();
        string code = "JR";

    }
    */

}
/*
public class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }

    public Catalog(IList<Item> items)
    {
        Items = items;
    }
}
*/



class Autor {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Natonality { get; set; }

    public Autor()
    {
        FirstName = "none";
        LastName = "none";
        Natonality = "none";

    }

    public Autor(string firstName, string lastName, string nationality) { 
    
        FirstName = firstName;
        LastName = lastName;
        nationality = nationality;
    
    }

    public string ToString() {

        return $"Autor | FirstName {FirstName}, LastName {LastName}, Nationality {Natonality}";
    
    }

    class Journal : Item {

        public int NumberFormatInfo { get; set; }

        Journal() {




        }

        Journal(string title, int id, string publisher, DateTime dateOfIssue,int number) { 
        
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
            NumberFormatInfo = number;
        
        }

    
    


}
















class Program { 

static void Main(string[] args)
    {


    }

}