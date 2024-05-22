using System.Net.Sockets;
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



namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        private double liczba1, liczba2;
        bool bAdd = false, bSub = false, bMul = false, bDiv = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button Button_0)
            {
                 TextBox_Kal.Text += Button_0.Content;
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_1)
            {
                TextBox_Kal.Text += Button_1.Content;
            }
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_0)
            {
                TextBox_Kal.Text += Button_2.Content;
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_3)
            {
                TextBox_Kal.Text += Button_3.Content;
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_4)
            {
                TextBox_Kal.Text += Button_4.Content;
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_5)
            {
                TextBox_Kal.Text += Button_5.Content;
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_6)
            {
                TextBox_Kal.Text += Button_6.Content;
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_7)
            {
                TextBox_Kal.Text += Button_7.Content;
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_8)
            {
                TextBox_Kal.Text += Button_8.Content;
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_9)
            {
                TextBox_Kal.Text += Button_9.Content;
            }
        }

        private void Button_kropka_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_kropka)
            {
                TextBox_Kal.Text += ",";
            }
        }
        private void TextBox_Kal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_dod_Click(object sender, RoutedEventArgs e)
        {

            if (sender is Button Button_dod)
            {
               
                if (double.TryParse(TextBox_Kal.Text, out var value))
                {
                   liczba1 = value;
                   TextBox_Kal.Clear();
                   bAdd = true;
                }
                else
                {
                    TextBox_Kal.Text = "Błąd konwersji";
                }

                
            }
        }

        private void Button_odj_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_odj)
            {
                if (double.TryParse(TextBox_Kal.Text, out var value))
                {
                    liczba1 = value;
                    TextBox_Kal.Clear();
                    bSub = true;
                }
                else
                {
                    TextBox_Kal.Text = "Błąd konwersji";
                }
                
            }
        }

        private void Button_wycz_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_wycz)
            {
                
                TextBox_Kal.Clear();
                liczba1 = 0;
                liczba2 = 0;
                
            }
        }

        private void Button_razy_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_razy)
            {
                if (double.TryParse(TextBox_Kal.Text, out var value))
                {
                    liczba1 = value;
                    TextBox_Kal.Clear();
                    bMul = true;
                }
                else
                {
                    TextBox_Kal.Text = "Błąd konwersji";
                }
                
            }
        }

        private void Button_dziel_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_dziel)
            {
                if (double.TryParse(TextBox_Kal.Text, out var value))
                {
                    liczba1 = value;
                    TextBox_Kal.Clear();
                    bDiv = true;
                }
                else
                {
                    TextBox_Kal.Text = "Błąd konwersji";
                }
                
            }
        }

        private void Button_rowna_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button Button_rowna)
            {
                double wynik = 0;
                if (double.TryParse(TextBox_Kal.Text, out var value))
                {
                    liczba2 = value;
                }
                else
                {
                    TextBox_Kal.Text = "Błąd konwersji";
                }

                

                if (bAdd == true)
                {
                    wynik = liczba1 + liczba2;
                    TextBox_Kal.Text = wynik.ToString();
                    bAdd = false;
                }
                else if (bSub == true)
                {
                    wynik = liczba1 - liczba2;
                    TextBox_Kal.Text = wynik.ToString();
                    bSub = false;
                }
                else if (bMul == true)
                {
                    wynik = liczba1 * liczba2;
                    TextBox_Kal.Text = wynik.ToString();
                    bMul = false;
                }
                else if (bDiv == true && liczba2 == 0)
                {
                    
                    TextBox_Kal.Text = "Nie mozna dzielic przez 0";
                    bDiv = false;
                }
                else
                {
                    wynik = liczba1 / liczba2;
                    TextBox_Kal.Text = wynik.ToString();
                    bDiv = false;
                }
               

            }
        }
    }
}