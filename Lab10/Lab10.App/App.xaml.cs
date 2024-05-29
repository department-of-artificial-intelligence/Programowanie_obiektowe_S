using Lab10.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Lab10.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                var cns = context.Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<MSContext>(options => options.UseSqlServer(cns));
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
