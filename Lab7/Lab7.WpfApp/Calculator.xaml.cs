using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
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
        private string input = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if(button != null)
            {
                input += button.Content.ToString();
                //DisplayAttribute.Text = input;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Click_Clear(object sender, RoutedEventArgs e)
        {
            input = "";
            //DisplayAttribute.Text = "0";
        }

        private void Click_Operator(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int operacja;
            double wynik;
            /*
            if (button != null)
            {
                input += $"{button.Content}";
                DisplayAttribute.Text = input;
            }
            switch operacja
            {
                case 1:
                    {
                        wynik = liczba1 + liczba2;
                        break;
                    }
                case 2:
                    {
                        wynik = liczba1 - liczba2;
                        break;
                    }
                case 3:
                    {
                        wynik = liczba1 * liczba2;
                        break;
                    }
                case 4:
                    {
                        if (liczba2 != null)
                        {
                            wynik = liczba1 + liczba2;
                            break;
                        }
                        //std::cout >> "Blad";
                        break;
                    }
            
            }
        */
        }

        private void Click_Equals(object sender, RoutedEventArgs e)
        {
                double liczba1, liczba2;
                //bool b1 = double.TryParse(tbLiczba1.Text, out liczba1);
               // bool b2 = double.TryParse(tbLiczba2.Text, out liczba2);
                //double wynik = operacja(liczba1, liczba2);
        }

        private void Click_Dot(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Nr(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                input += button.Content.ToString();
                //DisplayAttribute.Text = input;
            }
        }
    }
}
