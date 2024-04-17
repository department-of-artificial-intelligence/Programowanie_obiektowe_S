using System.Windows;
using System.Windows.Controls;

namespace lab7.BLL
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b9_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRownaSie_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button bRownaSie)
            {
                Wyswietlanie.Text = (string)bRownaSie.Content;
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b1)
            {
                Wyswietlanie.Text += (string)b1.Content;
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
