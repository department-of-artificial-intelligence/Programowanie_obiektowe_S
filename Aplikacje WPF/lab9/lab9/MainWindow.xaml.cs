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

namespace lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private async Task AsyncMethod() // definicja metody asynchronicznej
        {
            await Task.Run(async () => // stworzenie nowego watku
            {
                await Task.Delay(5000); // zatrzymanie obecnego watku na okreslona ilosc czasu,
                                        // zadanie sumowania.
                long sum = 0;
                while (true)
                {
                    sum++;
                    if (sum == 1000000000)
                        break;
                }
                // wyswietlenie Id obecnego watku
                MessageBox.Show($"Async method {Thread.CurrentThread.ManagedThreadId.ToString()}");
            });
        }
        // rodzaje wywolan metody asynchronicznej
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // wywolanie metody asynchronicznej w nowym watku w sposob asynchroniczny,
            //zatrzymujac wykonanie watku glownego do momentu zakonczenia zadania nowego watku.
            await AsyncMethod();
            // wywolanie metody asynchronicznej w nowym watku w sposob synchroniczny,
            //zatrzymujac wykonanie watku glownego do momentu zakonczenia zadania nowego watku.
            AsyncMethod().Wait();
            // wywolanie metody asynchronicznej w nowym watku w sposob synchroniczny,
            // nie zatrzymujac wykonania watku glownego.
            // W takim przypadku zadanie moze zakonczyc sie pozniej niz praca watku glownego.
            AsyncMethod();
        }
    }
}