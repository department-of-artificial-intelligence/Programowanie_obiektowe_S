using Lab10.DAL.EF;
using Lab10.Model.Entities;
using Microsoft.EntityFrameworkCore;
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

namespace Lab10.WpfApp
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly Student? _student;
        public AddGradeWindow(ApplicationDbContext dbContext, Student student = null)
        {
            _dbContext = dbContext;
            DataContext = _student = student ?? new Student();
            InitializeComponent();
        }
    }
}
