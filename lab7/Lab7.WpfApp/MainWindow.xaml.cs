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

namespace Lab7.WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Func<double, double, double> Add = (x, y) => x + y;
        Func<double, double, double> Substract = (x, y) => x - y;
        Func<double, double, double> Multiply = (x, y) => x * y;
        Func<double, double, double> Divide = (x, y) => x / y;

        double parametr1 = 0.0;
        Func<double, double, double> akcja;

        public MainWindow() {
            InitializeComponent();

        }

        private void on_number_click(object sender, RoutedEventArgs e) {
            if (sender is Button button) {
                MainText.Text = MainText.Text + button.Content as string;
            }
        }

        private void on_action_click(object sender, RoutedEventArgs e) {
            if (sender is Button button) {
                if (button.Name == "add") {
                    this.akcja = Add;
                    this.parametr1 = double.Parse(MainText.Text);
                    MainText.Text = "";
                };
            }
        }

        private void on_equals_click(object sender, RoutedEventArgs e) {
            if (sender is Button button) {
                double druga;
                MainText.Text = akcja(parametr1, double.Parse(MainText.Text)).ToString();
            }
        }

    }
}