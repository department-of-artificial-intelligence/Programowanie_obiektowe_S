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
    class AddProductCommand : CommandBase
    {
        private ApplicationDbContext dbContext;
        private DataGrid shopDataGrid;
        private Action hide;
        private Action show;

        public AddProductCommand(ApplicationDbContext dbContext, DataGrid shopDataGrid, Action hide, Action show)
        {
            this.dbContext = dbContext;
            this.shopDataGrid = shopDataGrid;
            this.hide = hide;
            this.show = show;
        }

        public override void Execute(object? parameter)
        {
            hide();
            if (shopDataGrid.SelectedItem != null && shopDataGrid.SelectedItem is Shop s)
            {
                CreateProductWindow createWindow = new CreateProductWindow(dbContext, s);
                if (createWindow.ShowDialog() ?? false)
                    shopDataGrid.SetGrid(dbContext.Shops.Include(stud => stud.Products));
            }
            show();
        }
    }
}
