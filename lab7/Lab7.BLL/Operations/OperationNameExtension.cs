using Lab7.BLL.Operations.MathOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab7.BLL.Operations.MathOperations {
	public static class OperationNameExtension {
		public static OperationName StringToOperationName(this OperationName op, string text) {
			return (OperationName)Enum.Parse(typeof(OperationName), text);
		}
	}
}
