using Kolokwium.DAL.EF;
using Kolokwium.Model;
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

namespace Kolokwium.WpfApp
{
    /// <summary>
    /// Interaction logic for Add_Edit_Tree.xaml
    /// </summary>
    public partial class Add_Edit_Tree : Window
    {
        private readonly ApplicationDbContext _dbContext;
        private Park? _park;
        public Add_Edit_Tree(ApplicationDbContext dbContext, Park park = null)
        {
            _dbContext = dbContext;
            InitializeComponent();
            _park = park;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, @"^\p{L}{1,12}$") ||
                !Regex.IsMatch(HeightTextBox.Text, @"^[0-9]{1,10}$") ||
                !Regex.IsMatch(RadiusTextBox.Text, @"^[0-9]{1,10}$")
                )
            {
                MessageBox.Show("Invalid data");
                return;
            }
            else
            {
                Tree t = new Tree();
                t.Name = NameTextBox.Text;
                t.Height = Int32.Parse(HeightTextBox.Text);
                t.Raduis = Int32.Parse(RadiusTextBox.Text);
                _park.Trees.Add(t);
                _dbContext.SaveChanges();
            }
            DialogResult = true;
        }
    }
}
