using System.Windows;

namespace Lab9
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
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
}
