using Kolokwium.DAL.EF;
using Kolokwium.Model;
using Kolokwium.WpfApp.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kolokwium.WpfApp.Commands
{
    public class DeleteShopCommand : CommandBase
    {
        private ApplicationDbContext dbContext;
        private DataGrid shopDataGrid;

        public DeleteShopCommand(ApplicationDbContext dbContext, DataGrid shopDataGrid)
        {
            this.dbContext = dbContext;
            this.shopDataGrid = shopDataGrid;
        }

        public override void Execute(object? parameter)
        {
            if (shopDataGrid.SelectedItem != null)
                if (shopDataGrid.SelectedItem is Shop s)
                {
                    dbContext.Shops.Remove(s);
                    dbContext.SaveChanges();
                    GridExtensions.SetGrid(shopDataGrid, dbContext.Shops.Include(stud => stud.Products));
                }
        }
    }
}
