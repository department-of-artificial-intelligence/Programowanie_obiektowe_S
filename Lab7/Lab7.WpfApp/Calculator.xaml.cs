using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7.WpfApp
{
    enum WhoWasLast
    {
        SIGN,DOT,NONE
    }
    public partial class Calculator : Window
    {
        WhoWasLast last=WhoWasLast.NONE;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (niceInput.Text=="0")
                niceInput.Text = (string)(sender as Button).Content;
            else
                niceInput.Text += (sender as Button).Content;
        }
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if (last != WhoWasLast.DOT)
            {
                last = WhoWasLast.DOT;
                if (niceInput.Text[niceInput.Text.Length - 1] != ','&& !IsSign(niceInput.Text[niceInput.Text.Length - 1]))
                    niceInput.Text += ',';
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            niceInput.Text = "0";
        }
        private bool IsSign(char s)
        {
            return s == '-' || s == '+' || s == '/' || s == '*'||s==',';
        }
        private void Button_Click_Sign(object sender, RoutedEventArgs e)
        {
            last = WhoWasLast.SIGN;
            if (!IsSign(niceInput.Text[niceInput.Text.Length-1]))
                niceInput.Text += (sender as Button).Content;
            else
                niceInput.Text = niceInput.Text.Substring(0,niceInput.Text.Length-1)+(string)(sender as Button).Content;
        }
        private decimal DoTwoNumbers(decimal number1, decimal number2 ,char sign)
        {
            switch (sign)
            {
                case '+':
                    return number1+number2;

                case '-':
                    return number1 - number2;

                case '*':
                    return number1 * number2;
                case '/':
                    if(number2!=0)
                        return number1 / number2;
                    return 0;
            }
            return 0;
        }
        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            string equation = niceInput.Text;
            string[] split_numbers = equation.Split('+','-','/','*').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            string[] split_signs = equation.Split('0','9','8','7','6','5','4','3','2','1',',').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            if(split_signs.Length!= split_numbers.Length-1)
            {
                string messageBoxText = "Your equation is defined wrong by the system. Please make sure its correct.";
                string caption = "Warning";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                return;
            }
            decimal result = Convert.ToDecimal(split_numbers[0]);
            for (int i = 1;i<split_numbers.Length; i++)
            {
                result = DoTwoNumbers(result, Convert.ToDecimal(split_numbers[i]), split_signs[i-1][0]);
            }
            niceInput.Text=result.ToString();
            last = WhoWasLast.DOT;
        }
    }
}
