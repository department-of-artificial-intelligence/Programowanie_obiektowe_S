using System;
using System.Collections.Generic;
using System.Data;
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
        private bool IsResult = false;
        public Calculator()
        {
            InitializeComponent();
        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            LabelResult.Content = LabelResult.Content?.ToString() + btn?.Content.ToString();
        }

        private void ButtonClickClear(object sender, RoutedEventArgs e)
        {
            LabelResult.Content = "";
        }

        private void ButtonClickEquals(object sender, RoutedEventArgs e)
        {
            string expression = LabelResult.Content?.ToString();

            try
            {
                var result = new DataTable().Compute(expression, null);
                LabelResult.Content = result.ToString();
            }
            catch
            {
                LabelResult.Content = "Błąd";
            }
        }
    }
}
