using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class zad1
    {
        abstract class Item
        {
            protected int _id;
            protected string _title;
            protected string _publisher;
            protected DateTime _dateOfIssue;

            public int Id { get { return _id; } set { _id = value; } }
            public string Title { get { return _title; } set { _title = value; } }
            public string Publisher { get { return _publisher; } set { _publisher = value; } }
            public DateTime DateOfIssie { get; set; }
            public Item() { }
            public Item(int id, string title, string publisher, DateTime dateOfIssie)
            {
                Title = title;
                Publisher = publisher;
                Id = id;
                DateOfIssie = dateOfIssie;
            }

            public override string ToString()
            {
                return $"id: {_id} title: {_title} publisher: {_publisher} Data wysypania sie: {_dateOfIssue} di endo";
            }
             public void details()
            {

            }

            public abstract string GenerateBarCode();

        }

        class Catalog
        {
            public IList<Item> Items { get; set; }
            public string ThermaticDepartment { get; set; }
            public Catalog(IList<Item> items) {
                Items = items;
            }
            public Catalog(string thermaticDepartmenth, IList<Item> items) {
                Items = items;
                ThermaticDepartment = thermaticDepartmenth;
            }

            public void AddItem(Item item)
            {

            }

            public override string ToString()
            {
                return $"xd";
            }

            public void ShowAllItems()
            {
                foreach (Item item in Items) {
                    Console.WriteLine(item); 
                }
                
            }



        }
    }




        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
