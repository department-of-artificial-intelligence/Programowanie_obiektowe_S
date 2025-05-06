using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = secondNumber = result = 0;
            operation = "";
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber; break;
                case "-":
                    result = firstNumber - secondNumber; break;
                case "*":
                    result = firstNumber * secondNumber; break;
                case "/":
                    result = secondNumber != 0 ? firstNumber / secondNumber : 0; break;
            }

            txtDisplay.Text = result.ToString();
        }
    }
}
