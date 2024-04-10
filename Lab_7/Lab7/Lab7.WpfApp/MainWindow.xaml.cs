using System.Windows;

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

        private void Text_Box_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        //0
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 0;

        }
        //1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 1;
        }
        //2
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 2;
        }
        //3
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 3;
        }
        //4
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 4;
        }
        //5
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 5;
        }
        //6
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 6;
        }
        //7
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 7;
        }
        //8
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 8;
        }
        //9
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += 9;
        }
        //.
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += ".";
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += "+";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += "-";
        }
        // =
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

            if ()
            {


            }


        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += "/";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Text_Box.Text += "*";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Text_Box.Clear();
        }
    }
}