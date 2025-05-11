namespace Lab7.BLL.Operations.MathOperations {
	public class MathOperations {

		private Dictionary<OperationName, IOperation> operations;
		public Dictionary<OperationName, IOperation> Operations { get => operations; }

		public MathOperations() {
			operations = new Dictionary<OperationName, IOperation>();
			Operations.Add(OperationName.add, new Addition());
			Operations.Add(OperationName.substract, new Substraction());
			Operations.Add(OperationName.multiply, new Multiplication());
			Operations.Add(OperationName.divide, new Division());
		}
	}

}
