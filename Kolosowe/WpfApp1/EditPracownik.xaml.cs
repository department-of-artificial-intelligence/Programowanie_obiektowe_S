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
    public partial class EditPracownik : Window
    {
        public Pracownik pracownik = new Pracownik();
        public EditPracownik(Pracownik? pracownik = null)
        {
            InitializeComponent();
            if (pracownik != null)
            {
                this.pracownik = pracownik;
                imieTekst.Text = pracownik.Imie;
                nazwiskoTekst.Text = pracownik.Nazwisko;
                rokTekst.Text = pracownik.RokUrodzenia.ToString();
                miesiacTekst.Text = pracownik.MiesiacUrodzenia.ToString();
                dzienTekst.Text = pracownik.DzienUrodzenia.ToString();
                IDTekst.Text = pracownik.Id.ToString();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(rokTekst.Text, out int rok) && int.TryParse(miesiacTekst.Text, out int miesiac) && int.TryParse(dzienTekst.Text, out int dzien))
            {
                pracownik.Imie = imieTekst.Text;
                pracownik.Nazwisko = nazwiskoTekst.Text;
                pracownik.RokUrodzenia = rok;
                pracownik.MiesiacUrodzenia = miesiac;
                pracownik.DzienUrodzenia = dzien;
                if (int.TryParse(IDTekst.Text, out int id))
                {
                    pracownik.Id = id;
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
                MessageBox.Show("Nieprawidłowe dane urodzenia");
            }
        }
    }
}
