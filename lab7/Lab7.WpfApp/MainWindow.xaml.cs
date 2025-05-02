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

namespace Lab7.WpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double firstNumber = 0;
    private double secondNumber = 0;
    private Func<double, double, double> currentOperation = null;
    private bool isOperatorClicked = false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnButtonNumberClick(object sender, RoutedEventArgs e)
    {
        var clickedButton = sender as Button;
        if (isOperatorClicked)
        {
            display.Text = string.Empty;
            isOperatorClicked = false;
        }
        display.Text += clickedButton.Content.ToString();
    }
    private void OnButtonOperationClick(object sender, RoutedEventArgs e)
    {
        var operation = (sender as Button).Content.ToString();
        if (double.TryParse(display.Text, out firstNumber))
        {
            isOperatorClicked = true;
            display.Text += $" {operation} ";

            switch (operation)
            {
                case "+":
                    currentOperation = (a, b) => a + b;
                    break;
                case "-":
                    currentOperation = (a, b) => a - b;
                    break;
                case "*":
                    currentOperation = (a, b) => a * b;
                    break;
                case "/":
                    currentOperation = (a, b) => b == 0 ? throw new DivideByZeroException() : a / b;
                    break;
            }
        }
    }
    private void OnButtonResultClick(object sender, RoutedEventArgs e)
    {
        if (currentOperation != null && double.TryParse(display.Text, out secondNumber))
        {
            try
            {
                double result = currentOperation(firstNumber, secondNumber);
                display.Text = result.ToString();
                firstNumber = result;
                isOperatorClicked = true;
            }
            catch
            {
                display.Text = "Error";
            }
        }

    }
    private void OnButtonClearClick(object sender, RoutedEventArgs e)
    {
        display.Text = string.Empty;
        firstNumber = 0;
        secondNumber = 0;
        currentOperation = null;
        isOperatorClicked = false;
    }

}
