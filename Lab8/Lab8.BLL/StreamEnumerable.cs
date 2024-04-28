using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
	public class StreamEnumerable<T> : IEnumerable<T>, IDisposable where T : new()
	{
		private readonly StreamReader _streamReader;
		public StreamEnumerable(StreamReader streamReader)
		{
			_streamReader = streamReader;
		}
		public IEnumerator<T> GetEnumerator()
		{
			while (!_streamReader.EndOfStream)
			{
				yield return _streamReader.Load<T>().Result;
			}
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		public void Dispose()
		{
			_streamReader.Close();
			GC.SuppressFinalize(this);
		}
	}
}
