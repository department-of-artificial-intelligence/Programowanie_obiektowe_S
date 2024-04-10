using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock textBlock;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button InputButton)
            {
                if (textBlock.Text == "0" || textBlock.Text=="Err") textBlock.Text = "";
                textBlock.Text += (string)InputButton.Content;
            }
        }

        private void TextField_Initialized(object sender, EventArgs e)
        {
            if (sender is TextBlock tb) textBlock = tb;
        }

        private void _EraseBtn_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "0";
        }

        private void _EquBtn_Click(object sender, RoutedEventArgs e)
        {

            DataTable dt = new DataTable();
            try
            {
                textBlock.Text = $"{dt.Compute((textBlock.Text), "")}";
            }
            catch
            {
                textBlock.Text = "Err";
            }
            if (textBlock.Text == "∞" || textBlock.Text == "-∞") textBlock.Text = "Err";
        }
    }
}