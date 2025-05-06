using System.Windows;

namespace Lab7.WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCalculator_Click(object sender, RoutedEventArgs e)
        {
            Calculator calcWindow = new Calculator();
            calcWindow.Show();
        }
    }
}
