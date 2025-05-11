using Lab7.BLL.Operations.MathOperations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7.WpfApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private decimal firstNumber;

		private MathOperations mathOperations;
		private Func<decimal, decimal, decimal> currentMathOperation;

		public MainWindow() {
			InitializeComponent();
			mathOperations = new MathOperations();
			this.currentMathOperation = (x, y) => 0.0m;
			this.firstNumber = 0.0m;
		}

		private void on_number_click(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				MainText.Text = MainText.Text + button.Content as string;
			}
		}

		private void on_action_click(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				OperationName op = new OperationName().StringToOperationName(button.Name);
				this.currentMathOperation = mathOperations.Operations[op].operation;
				this.firstNumber = decimal.Parse(MainText.Text.Replace('.', ','));
				MainText.Text = "";
			}
		}

		private void on_cancel_click(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				this.MainText.Text = "";
				this.firstNumber = 0.0m;
				currentMathOperation = (decimal x, decimal y) => 0.0m;
			}
		}

		private void on_equals_click(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				MainText.Text = currentMathOperation(firstNumber, decimal.Parse(MainText.Text)).ToString();
			}
		}

	}
}