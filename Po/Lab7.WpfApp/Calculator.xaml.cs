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
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        double num1,num2;
        bool bAdd=false, bSub=false,bMul=false, bDiv=false; 
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            
            TextBoxEq.Text += Button0.Content;
        }

        private void TextBoxEq_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            { 
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button1.Content;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button2.Content;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button3.Content;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button4.Content;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button5.Content;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button6.Content;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button7.Content;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button8.Content;
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(TextBoxEq.Text);

            TextBoxEq.Clear();

            bMul = true;
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(TextBoxEq.Text);

            TextBoxEq.Clear();

            bSub = true;
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(TextBoxEq.Text);

            TextBoxEq.Clear();

            bDiv = true;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEq.Text == "0")
            {
                TextBoxEq.Clear();
            }
            TextBoxEq.Text += Button9.Content;
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            
                TextBoxEq.Text += ButtonDot.Content;
            
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            num1 = Double.Parse(TextBoxEq.Text);
            
            TextBoxEq.Clear();
            
            bAdd = true;
            
        }

        private void ButtonEq_Click(object sender, RoutedEventArgs e)
        {
            double wynik = 0;
            num2 = Double.Parse(TextBoxEq.Text);
            if (bAdd == true)
            {
                wynik = num1 + num2;
                TextBoxEq.Text = wynik.ToString();
                
            }
            if (bMul == true)
            {
                wynik = num1 * num2;
                TextBoxEq.Text = wynik.ToString();
            }
            if (bSub == true)
            {
                wynik = num1 - num2;
                TextBoxEq.Text = wynik.ToString();
            }
            if(bDiv==true) {
                if (num2 == 0)
                {
                    TextBoxEq.Text = "Error! You can't divine by 0";
                }
                else { 
               
                    wynik = num1 / num2;
                    TextBoxEq.Text = wynik.ToString();
                }
            }
        }
    }
}
