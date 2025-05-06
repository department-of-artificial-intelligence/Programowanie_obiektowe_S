using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    interface IInfo
    {
        public string Nazwa { get; set; }
        public float Bilans();
        
    }
}
