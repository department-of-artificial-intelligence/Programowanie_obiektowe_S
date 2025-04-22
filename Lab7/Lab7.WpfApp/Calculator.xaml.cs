using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7.WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {

        public static double Divide(int a, int b) { return a / b; }
        public static double Add(int a, int b) { return a + b; }
        public static double Subtract(int a, int b) { return a - b; }
        public static double Multiply(int a, int b) { return a * b; }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click_Number(object sender, RoutedEventArgs e)
        {
            //Button content = Button(sender);
            //string content = (string)Btn.content;
            //if(sender is Button)
            //{

            //}

        }
        private void Button_Click_Operation(object sender, RoutedEventArgs e)
        {

        }

        //mozna odnosic sie do contentu
        //operacje mozna zrobic z pomoca switcha
    }
}
