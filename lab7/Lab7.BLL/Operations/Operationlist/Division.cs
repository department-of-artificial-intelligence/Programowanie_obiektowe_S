using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.BLL.Operations.MathOperations {
	class Division : IOperation {
		public OperationName name => OperationName.divide;
		public Func<decimal, decimal, decimal> operation => (x, y) => x / y;
	}
}
