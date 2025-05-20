using System;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace Lab7.BBL {
    public partial class Calculator : Window {
        private double _pierwszaLiczba = 0;
        private double _drugaLiczba = 0;
        private string _operacja = "";
        private bool _czyNowaLiczba = true;

        public Calculator() {
            InitializeComponent();
        }

        private void PobierzLiczbe(object sender, RoutedEventArgs e) {
            Button przycisk = (Button)sender;
            string wartosc = przycisk.Content.ToString();

            if (_czyNowaLiczba) {
                Wynik.Text = "";
                _czyNowaLiczba = false;
            }

            if (wartosc == "." && Wynik.Text.Contains(".")) {
                return;
            }

            Wynik.Text += wartosc;
        }

        private void Wyczysc(object sender, RoutedEventArgs e) {
            Wynik.Text = "0";
            _pierwszaLiczba = 0;
            _drugaLiczba = 0;
            _operacja = "";
            _czyNowaLiczba = true;
        }

        private void UstawOperacje(string operacja) {
            if (!string.IsNullOrEmpty(Wynik.Text)) {
                _pierwszaLiczba = double.Parse(Wynik.Text, CultureInfo.InvariantCulture);
                _operacja = operacja;
                _czyNowaLiczba = true;
            }
        }

        private void Sumuj(object sender, RoutedEventArgs e) {
            UstawOperacje("+");
        }

        private void Odejmuj(object sender, RoutedEventArgs e) {
            UstawOperacje("-");
        }

        private void Mnoz(object sender, RoutedEventArgs e) {
            UstawOperacje("*");
        }

        private void Dziel(object sender, RoutedEventArgs e) {
            UstawOperacje("/");
        }

        private void Rownaj(object sender, RoutedEventArgs e) {
            if (!string.IsNullOrEmpty(_operacja) && !_czyNowaLiczba) {
                _drugaLiczba = double.Parse(Wynik.Text, CultureInfo.InvariantCulture);
                double wynik = 0;

                switch (_operacja) {
                    case "+":
                        wynik = _pierwszaLiczba + _drugaLiczba;
                        break;
                    case "-":
                        wynik = _pierwszaLiczba - _drugaLiczba;
                        break;
                    case "*":
                        wynik = _pierwszaLiczba * _drugaLiczba;
                        break;
                    case "/":
                        if (_drugaLiczba != 0) {
                            wynik = _pierwszaLiczba / _drugaLiczba;
                        } else {
                            MessageBox.Show("Nie można dzielić przez zero!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                            Wyczysc(sender, e);
                            return;
                        }
                        break;
                }

                Wynik.Text = wynik.ToString();
                _pierwszaLiczba = wynik;
                _czyNowaLiczba = true;
                _operacja = "";
            }
        }
    }
}