using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using lab11_1.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace lab11_1.WpfApp;
public partial class App : Application
{
    private readonly IHost _host;
    public App()
    {
        _host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
        {
            var cns = context.Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(cns));
            services.AddTransient<MainWindow>();
        }).Build();
    }
    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = _host.Services.GetService<MainWindow>();
        mainWindow?.Show();
    }
}
