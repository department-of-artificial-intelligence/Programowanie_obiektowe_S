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
using Lab8.BLL;

namespace Lab8.WpfApp
{
    /// <summary>
    /// Interaction logic for ShowGradeWindow.xaml
    /// </summary>
    public partial class ShowGradeWindow : Window
    {
        public ShowGradeWindow(IList<Grade>? grade =null)
        {
            InitializeComponent();
            MainWindow s = new MainWindow();
            MessageBox.Show(grade.ToString());
            DataGridShowsGrade.Columns.Add(new DataGridTextColumn()
            { Header = "Name Subject", Binding = new Binding("NameSubject") });
            
            DataGridShowsGrade.Columns.Add(new DataGridTextColumn()
            { Header = "Weight", Binding = new Binding("Weight") });

            DataGridShowsGrade.Columns.Add(new DataGridTextColumn()
            { Header = "Grade", Binding = new Binding("GradeS") });
            
            DataGridShowsGrade.AutoGenerateColumns = false;
            DataGridShowsGrade.ItemsSource = grade;
        }
    }
}
