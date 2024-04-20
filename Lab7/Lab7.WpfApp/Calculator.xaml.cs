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
        public char znak;
        public double x;
        public Calculator()
        {
            InitializeComponent();
            zero.Click += NumberButtonClick;
            jeden.Click += NumberButtonClick;
            dwa.Click += NumberButtonClick;
            trzy.Click += NumberButtonClick;
            cztery.Click += NumberButtonClick;
            piec.Click += NumberButtonClick;
            szesc.Click += NumberButtonClick;
            siedem.Click += NumberButtonClick;
            osiem.Click += NumberButtonClick;
            dziewiec.Click += NumberButtonClick;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (znak == 'p')
            {
                znak = '+';
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
            }
        }
        
        private void rownasie_Click(object sender, RoutedEventArgs e)
        {
            if (textinout.Text != string.Empty)
            {
                double z;
                double y = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
                switch (znak)
                {
                    case '+':
                        z = x + y;
                        textinout.Text = z.ToString();
                        break;
                    case '-':
                        z = x - y;
                        textinout.Text = Convert.ToString(z);
                        break;
                    case '*':
                        z = x * y;
                        textinout.Text = Convert.ToString(z);
                        break;
                    case '/':
                        z = x / y;
                        textinout.Text = Convert.ToString(z);
                        break;
                    case 'p':
                        textinout.Text = Convert.ToString(y);
                        break;
                    default:
                        textinout.Text = Convert.ToString(y);
                        break;
                }
                znak = 'p';
            }
            
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (znak == 'p') 
            { 
                znak = '-';
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (znak == 'p')
            {
                znak = '/';
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
            }
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            if (znak == 'p')
            {
                znak = '*';
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
            }
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (textinout.Text != string.Empty)
            {
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
                x = Math.Sqrt(x);
                textinout.Text = x.ToString();
            }
        }

        private void potega_Click(object sender, RoutedEventArgs e)
        {
            if (textinout.Text != string.Empty)
            {
                x = Convert.ToDouble(textinout.Text.Trim());
                textinout.Clear();
                x = x * x;
                textinout.Text = x.ToString();
            }
        }

        private void clearall_Click(object sender, RoutedEventArgs e)
        {
            if (textinout.Text != string.Empty)
            {
                var str = textinout.Text;
                str = str.Trim();
                string stringWithoutLastCharacter = str.Substring(0, str.Length - 1);
                textinout.Text = stringWithoutLastCharacter;
            }
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            int index = textinout.Text.IndexOf(',');
            if(textinout.Text != string.Empty && !textinout.Text.Contains(','))
            {
                var str = textinout.Text;
                str += ',';
                textinout.Text = str;
            }
        }
        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textinout.Text += button.Content;
        }
    }
}
