using Lab10.DAL.EF;
using Lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.Windows.Shapes;
namespace Lab10.WpfApp;
public partial class AddEditStudentWindow : Window
{
    private readonly ApplicationDbContext _dbContext;
    private readonly Student? _student;
    public AddEditStudentWindow(ApplicationDbContext dbContext, Student student = null)
    {
        _dbContext = dbContext;
        DataContext = _student = student ?? new Student();
        InitializeComponent();
    }
    private void ButtonSaveStudent_Click(object sender, RoutedEventArgs e)
    {
        // walidacja danych
        if (!Regex.IsMatch(TextBoxFirstName.Text, @"^\p{Lu}{1,12}\p{Ll}{1,12}$") ||
        !Regex.IsMatch(TextBoxSurName.Text, @"^\p{L}{1,12}$") ||
        !Regex.IsMatch(TextBoxFaculty.Text, @"^\p{L}{1,12}$") ||
        !Regex.IsMatch(TextBoxStudentIndex.Text, @"^[0-9]{4,10}$") ||
        !DatePickerDateOfBirth.SelectedDate.HasValue)
        {
            MessageBox.Show("Invalid data");
            return;
        }
        if (!_dbContext.Students.Contains(_student)) // sprawdzenie czy encja istnieje w kontekscie
            _dbContext.Students.Add(_student); // dodanie encji do kontekstu
        else
            _dbContext.Students.Update(_student); // modyfikacja encji w kontekscie
        _dbContext.SaveChanges(); // wygenerowanie SQL oraz wykonanie go na bazie danych
        DialogResult = true; // ustawienie flagi DialogResult aby okno nadrzędne mogło kontynuować pracę
    }
}
