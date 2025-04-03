using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class DisplayActionExtensions
    {
        public static void Print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        public static void Print(IList<object> list)
        {
            if (list != null)
            {
                foreach (object obj in list)
                {
                    Print(obj);
                }
            }
        }
    }
}