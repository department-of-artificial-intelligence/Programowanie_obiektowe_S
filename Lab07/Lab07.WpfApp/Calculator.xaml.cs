using Lab07.BBL;
using System.Windows;
using System.Windows.Controls;

namespace Lab07.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private Button[] NumberButtons;
        private OperationType operationType;
        private double? number1, number2;
        public Calculator()
        {
            InitializeComponent();
        }

        public void OnInit(object sender, RoutedEventArgs e)
        {
            NumberButtons = new Button[]
            {
                button0,
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
            };
            for (int i = 0; i < NumberButtons.Length; i++)
            {
                int number = i;
                NumberButtons[i].Click += (sender, e) => textBox.Text += number;
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Abort();
        }

        private void Abort()
        {
            textBox.Clear();
            number1 = null;
            number2 = null;
            operationType = OperationType.Unselected;
        }

        private void OnOperationButtonClick(OperationType operationType)
        {
            this.operationType = operationType;
            textBox.Clear();
        }

        private void GetNumber()
        {
            var isNumber = double.TryParse(textBox.Text, out double res);
            if (isNumber)
            {
                if (number1 == null)
                {
                    number1 = res;
                }
                else
                {
                    number2 = res;
                }
            }
            else
            {
                Abort();
            }
        }
    }
}
