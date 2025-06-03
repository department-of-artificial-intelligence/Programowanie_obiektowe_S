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

namespace WpfApp1
{
    public partial class EditGabinet : Window
    {
        public Gabinet gabinet = new Gabinet();
        public EditGabinet(Gabinet? gabinet = null)
        {
            InitializeComponent();
            if (gabinet != null)
            {
                this.gabinet = gabinet;
                adresTekst.Text = gabinet.Adres;
                liczbaTekst.Text = gabinet.LiczbaPracownikow.ToString();
                numerTekst.Text = gabinet.NumerGabinetu.ToString();
                IdTekst.Text = gabinet.Id.ToString();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczbaTekst.Text, out int liczba) && int.TryParse(numerTekst.Text, out int numer))
            {
                gabinet.Adres = adresTekst.Text;
                gabinet.LiczbaPracownikow = liczba;
                gabinet.NumerGabinetu = numer;
                if(int.TryParse(IdTekst.Text, out int id)) 
                { 
                       gabinet.Id = id;
                }
                else
                {
                    MessageBox.Show("Nieprawidłowe ID");
                    return;
                }
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane. Proszę sprawdzić wprowadzone wartości.");
            }
        }
    }
}
