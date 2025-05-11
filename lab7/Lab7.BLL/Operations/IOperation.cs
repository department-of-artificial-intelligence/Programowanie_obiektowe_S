using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.BLL.Operations.MathOperations {
	public interface IOperation {
		OperationName name { get; }
		Func<decimal, decimal, decimal> operation { get; }
	}
}
