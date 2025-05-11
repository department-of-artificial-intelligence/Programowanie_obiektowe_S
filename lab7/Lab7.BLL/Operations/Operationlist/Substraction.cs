using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.BLL.Operations.MathOperations {
	class Substraction : IOperation {
		public OperationName name => OperationName.substract;
		public Func<decimal, decimal, decimal> operation => (x, y) => x - y;
	}
}
