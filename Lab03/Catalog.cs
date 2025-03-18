using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Catalog : Item
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        //public Catalog() { }
        public Catalog(IList<Item> items) {  Items = items; }
        public Catalog(string thematicDepartment) {  ThematicDepartment = thematicDepartment; }
        public void AddItem(Item item) { Items.Add(item);}
        //public void RemoveItem(Item item) { Items.Remove(item);}
        //public void Clear() { Items.Clear(); }
        public string ToString()
        {
            //return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                
            }
        }


    }
}
