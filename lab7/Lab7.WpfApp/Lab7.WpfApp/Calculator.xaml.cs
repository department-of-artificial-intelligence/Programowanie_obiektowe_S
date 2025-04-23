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
        public Calculator()
        {
            InitializeComponent();
        }

        float suma = 0;
        float temp = 0;
        int znak = 0;
        string pusty = string.Empty;
        //enum
        //jedno zdarzenie do którego podpięte są przyciski


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            pusty +=1;
            if (sender is Button button2)
            {
                Display.Text = pusty;
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            pusty +=2;
            if (sender is Button button2)
            {
                Display.Text = pusty;
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            pusty +=3;
            if (sender is Button button3)
            {
                Display.Text = pusty;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            pusty +=4;
            if (sender is Button button4)
            {
                Display.Text = pusty;
            }
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            pusty +=5;
            if (sender is Button button5)
            {
                Display.Text = pusty;
            }
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            pusty +=6;
            if (sender is Button button6)
            {
                Display.Text = pusty;
            }
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            pusty +=7;
            if (sender is Button button7)
            {
                Display.Text = pusty;
            }
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            pusty +=8;
            if (sender is Button button8)
            {
                Display.Text = pusty;
            }
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            pusty +=9;
            if (sender is Button button9)
            {
                Display.Text = pusty;
            }
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            pusty +=0;
            if (sender is Button button0)
            {
                Display.Text = pusty;
            }
        }

        void sprawdz()
        {
            switch (znak)
            {
                case 0:
                    suma = temp;
                    break;
                case 1:
                    suma = suma + temp;
                    break;
                case 2:
                    suma = suma - temp;
                    break;
                case 3:
                    suma = suma * temp;
                    break;
                case 4:
                    suma = suma / temp;
                    break;

            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {   
            float.TryParse(pusty, out temp);
            sprawdz();
            znak = 1;
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(pusty, out temp);
            sprawdz();
            znak = 2;
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(pusty, out temp);
            sprawdz();
            znak = 3;
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(pusty, out temp);
            sprawdz();
            znak = 4;
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }

        private void buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(pusty, out temp);
            sprawdz();
            znak = 0;
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(pusty, out temp);
            znak = 0;
            sprawdz();            
            pusty = string.Empty;
            Display.Text = suma.ToString();
        }
    }
}
