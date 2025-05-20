using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lab11.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    // Publiczna właściwość NewGrade dostępna dla MainWindow
    public Grade NewGrade { get; private set; }

    public AddGradeWindow()
    {
        InitializeComponent();
    }

    private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
    {
        // Walidacja danych wejściowych
        if (string.IsNullOrWhiteSpace(TextBoxSubject.Text) ||
            !double.TryParse(TextBoxScore.Text, out double score) || score < 2.0 || score > 5.0)
        {
            MessageBox.Show("Invalid input. Please ensure the score is between 2.0 and 5.0 and subject is not empty.");
            return;
        }

        // Tworzymy nową ocenę
        NewGrade = new Grade(TextBoxSubject.Text, score, DatePickerGradeDate.SelectedDate ?? DateTime.Now);

        // Ustawiamy DialogResult na true, aby główne okno mogło odczytać wynik
        DialogResult = true;
    }
}
