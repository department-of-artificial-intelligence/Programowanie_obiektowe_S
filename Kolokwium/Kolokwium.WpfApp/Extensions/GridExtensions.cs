using Kolokwium.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Kolokwium.WpfApp.Extensions
{
    public static class GridExtensions
    {
        public static void SetGrid<T>(this DataGrid dataGrid, IEnumerable<T> list) where T : new()
        {
            dataGrid.Columns.Clear();
            var type = typeof(T);
            foreach (var prop in type.GetProperties())
                if (prop.GetCustomAttribute<HideAttribute>() == null)
                    dataGrid.Columns.Add(new System.Windows.Controls.DataGridTextColumn()
                    {
                        Header = prop.Name,
                        Binding = new Binding(prop.Name)
                    });
            dataGrid.AutoGenerateColumns = false;
            dataGrid.ItemsSource = list;
            dataGrid.Items.Refresh();
        }
    }
}
