using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Extensions
{
    public interface IContainer
    {
        IList<object> Items { get; }
    }

    public class Container : IContainer
    {
        // Implementacja kontenera
        public IList<object> Items { get; private set; }

        public Container()
        {
            Items = new List<object>();
        }
    }


}
