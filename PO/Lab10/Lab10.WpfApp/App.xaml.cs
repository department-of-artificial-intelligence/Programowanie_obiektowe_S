using System.Windows;
using Lab10.WpfApp;
using Lab10.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Lab11.WpfApp;
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