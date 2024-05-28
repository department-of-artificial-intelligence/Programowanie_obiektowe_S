using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class StreamEnumerable<T> : IEnumerable<T>, IDisposable where T : new ()
    {
        private readonly StreamReader streamReader;
        public StreamEnumerable(StreamReader streamReader)
        {
            this.streamReader = streamReader;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (!streamReader.EndOfStream)
            { 
                yield return streamReader.Load<T>().Result;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Dispose() { 
            streamReader.Close();
            GC.SuppressFinalize(this);
        }
    }
}
