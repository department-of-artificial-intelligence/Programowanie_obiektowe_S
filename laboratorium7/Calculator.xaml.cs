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

namespace laboratorium7
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private double liczba1 = 0;
        private string operacja = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void kliknij(object sender, RoutedEventArgs e)
        {
            if(sender is Button zm)
            {
                TekstCalc.Text += zm.Content;
            }
        }

        private void wyczysc(object sender, RoutedEventArgs e)
        {
            TekstCalc.Text = string.Empty;
        }

        private void opMat(object sender, RoutedEventArgs e)
        {
            if(sender is Button op && double.TryParse(TekstCalc.Text, out liczba1))
            {
                operacja = op.Content.ToString();
                TekstCalc.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Zla liczba");
            }
        }

        private void wynik(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TekstCalc.Text, out double liczba2))
            {
                double wynik = 0;

                switch (operacja)
                {
                    case "+":
                        wynik = liczba1 + liczba2;
                        break;
                    case "-":
                        wynik = liczba1 - liczba2;
                        break;
                    case "*":
                        wynik = liczba1 * liczba2;
                        break;
                    case "/":
                        if (liczba2 != 0)
                        {
                            wynik = liczba1 / liczba2;
                        }
                        else
                        {
                            MessageBox.Show("Nie dziel przez zero!");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Błąd operatora!");
                        return;
                }
                        TekstCalc.Text = wynik.ToString();
                        liczba1 = wynik;
                        operacja = "";
                
            }

            else
            {
                MessageBox.Show("Zla liczba!");
            }

        }

    }
}
