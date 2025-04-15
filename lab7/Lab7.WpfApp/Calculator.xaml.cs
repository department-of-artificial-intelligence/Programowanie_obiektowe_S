using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private bool isClear = true;

        public Calculator()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            string buttonContent = clickedButton.Content.ToString();

            if (buttonContent == "=")
            {
                tb.Text = new DataTable().Compute(tb.Text, null).ToString();
            }
            else if (buttonContent == "C")
            {
                tb.Clear();
            }
            else
            {
                if (isClear)
                {
                    tb.Text = buttonContent;
                    isClear = false;
                }
                else
                {
                    tb.Text += buttonContent;
                }
            }


        }




        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
