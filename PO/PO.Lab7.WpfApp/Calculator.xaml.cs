using System.Windows;
namespace PO.Lab7.WpfApp
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

        private void ButtonNoClick(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = sender.ToString();
        }
    }
}
