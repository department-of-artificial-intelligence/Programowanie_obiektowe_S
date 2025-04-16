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

namespace Lab7.WpfApp
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
        int i = 0;
        private void przycisk1_Click(object sender, RoutedEventArgs e)
        {
            
            if (sender is Button przycisk1)
            {
                i++;
                przycisk1.Content += $" {i} ";
                ButtonOk.Content += "world";
                if (label1.Content == "hello hell")
                {
                    label1.Content = "hello world";
                }
                else { label1.Content = "hello hell"; }
                labelText.Content = TextB.Text;


            }
        }
    }
}