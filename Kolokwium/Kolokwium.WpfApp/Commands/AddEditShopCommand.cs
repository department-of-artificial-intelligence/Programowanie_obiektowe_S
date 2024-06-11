using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Kolokwium.WpfApp.Extensions;
using Kolokwium.WpfApp.Windows;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kolokwium.WpfApp.Commands
{
    public class AddEditShopCommand : CommandBase
    {
        private ApplicationDbContext dbContext;
        private DataGrid dataGrid;
        private Action hide;
        private Action show;
        public AddEditShopCommand(ApplicationDbContext dbContext, DataGrid dataGrid, Action hide,Action show)
        {
            this.dbContext = dbContext;
            this.dataGrid = dataGrid;
            this.hide = hide;
            this.show = show;
        }

        public override void Execute(object? parameter)
        {
            hide();
            if (dataGrid.SelectedItem != null && dataGrid.SelectedItem is Shop s)
            {
                CreateWindow createWindow = new CreateWindow(dbContext, s);
                if (createWindow.ShowDialog() ?? false)
                    GridExtensions.SetGrid(dataGrid, dbContext.Shops.Include(stud => stud.Products));
            }
            else
            {
                CreateWindow createWindow = new CreateWindow(dbContext, null);
                if (createWindow.ShowDialog() ?? false)
                    GridExtensions.SetGrid(dataGrid, dbContext.Shops.Include(stud => stud.Products));
            }
            show();
        }
    }
}
