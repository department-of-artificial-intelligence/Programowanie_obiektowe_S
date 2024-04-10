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
using Lab7.BLL;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    /// 



    public partial class Calculator : Window
    {
        public string Result = "0";
        public string Result2 = "0";
        public string Action = "";


        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "1";
            }
            else Result += "1";
            TextBlock_Result.Text = Result;
        }
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "2";
            }
            else Result += "2";
            TextBlock_Result.Text = Result;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "3";
            }
            else Result += "3";
            TextBlock_Result.Text = Result;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "4";
            }
            else Result += "4";
            TextBlock_Result.Text = Result;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "5";
            }
            else Result += "5";
            TextBlock_Result.Text = Result;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "6";
            }
            else Result += "6";
            TextBlock_Result.Text = Result;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "7";
            }
            else Result += "7";
            TextBlock_Result.Text = Result;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "8";
            }
            else Result += "8";
            TextBlock_Result.Text = Result;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "9";
            }
            else Result += "9";
            TextBlock_Result.Text = Result;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (Result == "0")
            {
                Result = "0";
            }
            else Result += "0";
            TextBlock_Result.Text = Result;
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            Result2 = Result;
            Result = "0";
            TextBlock_Result.Text = Result;
            Action = "+";
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            Result2 = Result;
            Result = "0";
            TextBlock_Result.Text = Result;
            Action = "-";
        }

        private void Button_Multiply_Click(object sender, RoutedEventArgs e)
        {
            Result2 = Result;
            Result = "0";
            TextBlock_Result.Text = Result;
            Action = "*";
        }

        private void Button_Div_Click(object sender, RoutedEventArgs e)
        {
            Result2 = Result;
            Result = "0";
            TextBlock_Result.Text = Result;
            Action = "/";
        }

        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(Result2);
            double b = Convert.ToDouble(Result);
            switch(Action)
            {
                case "+":
                    TextBlock_Result.Text = "" + (a + b);
                    Result2 = (a + b).ToString();
                    break;
                case "-":
                    TextBlock_Result.Text = "" + (a - b);
                    Result2 = (a - b).ToString();
                    break;
                case "*":
                    TextBlock_Result.Text = "" + (a * b);
                    Result2 = (a * b).ToString();
                    break;
                case "/":
                    if (b != 0) { 
                        TextBlock_Result.Text = "" + (a / b);
                        Result2 = (a / b).ToString();
                    }
                    else
                        TextBlock_Result.Text = "NIE MOZNA!";
                    break;
                    default:
                    TextBlock_Result.Text = "??????????";
                    break;
            }



        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result = "0";
            Result2 = "0";
            Action = "";
            TextBlock_Result.Text = Result;
        }

        private void Button_DOT_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_Result.Text = "JA NIE RABOTAJU";
        }
    }
}
