﻿using Kolokwium1.DAL.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium1.WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
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

}
