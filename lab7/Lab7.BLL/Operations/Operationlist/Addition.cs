using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.BLL.Operations.MathOperations {
	public class Addition : IOperation {
		public OperationName name => OperationName.add;
		public Func<decimal, decimal, decimal> operation => (x, y) => x + y;
	}
}
