using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;
public partial class MainWindow : Window
{
    public List<Pracownik> Pracownicy { get; set; } = new List<Pracownik>();
    public List<Gabinet> Gabinety { get; set; } = new List<Gabinet>();
    public MainWindow()
    {
        Pracownicy = new List<Pracownik>
        {
            new Pracownik { Imie = "Jan", Nazwisko = "Kowalski", RokUrodzenia = 1985, MiesiacUrodzenia = 5, DzienUrodzenia = 15, Id = 1 },
            new Pracownik { Imie = "Anna", Nazwisko = "Nowak", RokUrodzenia = 1990, MiesiacUrodzenia = 3, DzienUrodzenia = 20, Id = 2 },
            new Pracownik { Imie = "Piotr", Nazwisko = "Zieliński", RokUrodzenia = 1988, MiesiacUrodzenia = 7, DzienUrodzenia = 10, Id = 3 }
        };
        InitializeComponent();
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Imię", Binding = new Binding("Imie") });
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Nazwisko", Binding = new Binding("Nazwisko") });
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Rok urodzenia", Binding = new Binding("RokUrodzenia") });
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Miesiąc urodzenia", Binding = new Binding("MiesiacUrodzenia") });
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Dzień urodzenia", Binding = new Binding("DzienUrodzenia") });
        DataGridPracownik.Columns.Add(new DataGridTextColumn { Header = "Id", Binding = new Binding("Id") });
        DataGridPracownik.AutoGenerateColumns = false;
        DataGridPracownik.ItemsSource = Pracownicy;

        Gabinety = new List<Gabinet>
        {
            new Gabinet { Adres = "ul. Kwiatowa 5", LiczbaPracownikow = 3, NumerGabinetu = 101, Id = 1 },
            new Gabinet { Adres = "ul. Słoneczna 10", LiczbaPracownikow = 2, NumerGabinetu = 102, Id = 2 },
            new Gabinet { Adres = "ul. Leśna 15", LiczbaPracownikow = 4, NumerGabinetu = 103, Id = 3 }
        };

        DataGridGabinet.Columns.Add(new DataGridTextColumn { Header = "Adres", Binding = new Binding("Adres") });
        DataGridGabinet.Columns.Add(new DataGridTextColumn { Header = "Liczba pracowników", Binding = new Binding("LiczbaPracownikow") });
        DataGridGabinet.Columns.Add(new DataGridTextColumn { Header = "Numer gabinetu", Binding = new Binding("NumerGabinetu") });
        DataGridGabinet.Columns.Add(new DataGridTextColumn { Header = "Id", Binding = new Binding("Id") });
        DataGridGabinet.AutoGenerateColumns = false;
        DataGridGabinet.ItemsSource = Gabinety;
        
        }
        private void EditPracownik(object sender, RoutedEventArgs e)
        {
        if(DataGridPracownik.SelectedItem is Pracownik selectedPracownik)
        {
            EditPracownik edytujPracownik = new EditPracownik(selectedPracownik);
            edytujPracownik.ShowDialog();
            selectedPracownik.Imie = edytujPracownik.pracownik.Imie;
            selectedPracownik.Nazwisko = edytujPracownik.pracownik.Nazwisko;
            selectedPracownik.RokUrodzenia = edytujPracownik.pracownik.RokUrodzenia;
            selectedPracownik.MiesiacUrodzenia = edytujPracownik.pracownik.MiesiacUrodzenia;
            selectedPracownik.DzienUrodzenia = edytujPracownik.pracownik.DzienUrodzenia;
            selectedPracownik.Id = edytujPracownik.pracownik.Id;
            DataGridPracownik.Items.Refresh();
        }
        else
        {
            MessageBox.Show("Proszę wybrać pracownika do edycji.");
        }
    }
        private void EditGabinet(object sender, RoutedEventArgs e)
        {
        if(DataGridGabinet.SelectedItem is Gabinet selectedGabinet)
        {
            EditGabinet edytujGabinet = new EditGabinet(selectedGabinet);
            edytujGabinet.ShowDialog();
            selectedGabinet.Adres = edytujGabinet.gabinet.Adres;
            selectedGabinet.LiczbaPracownikow = edytujGabinet.gabinet.LiczbaPracownikow;
            selectedGabinet.NumerGabinetu = edytujGabinet.gabinet.NumerGabinetu;
            selectedGabinet.Id = edytujGabinet.gabinet.Id;
            DataGridGabinet.Items.Refresh();
        }
        else
        {
            MessageBox.Show("Proszę wybrać gabinet do edycji.");
        }
    }
        private void Del(object sender, RoutedEventArgs e)
        {
            if (DataGridGabinet.SelectedItem is Gabinet selectedGabinet)
            {
                Gabinety.Remove(selectedGabinet);
                DataGridGabinet.Items.Refresh();
            }

            if (DataGridPracownik.SelectedItem is Pracownik selectedPracownik)
            {
                Pracownicy.Remove(selectedPracownik);
                DataGridPracownik.Items.Refresh();
            }
    }
}
