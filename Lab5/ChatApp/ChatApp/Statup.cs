using Microsoft.AspNetCore.Mvc;

public void ConfigureServices(IServiceCollection services)
{
    services.AddWebSocketManager(); services.Configure<CookiePolicyOptions>(options =>
    {
        options.CheckConsentNeeded = context => true; options.MinimumSameSitePolicy = SameSiteMode.None;
    });


    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
}
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {

    }
    else
    {

    }
    app.UseDeveloperExceptionPage();



    app.UseExceptionHandler("/Home/Error");
    var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
    var serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;

    app.UseWebSockets();
    app.MapWebSocketManager("/ws", serviceProvider.GetService<ChatMessageHandler>());
    app.UseStaticFiles();
    app.UseCookiePolicy();

    app.UseMvc(routes =>
    {
        routes.MapRoute(name: "default",
        template: "{controller=Chat}/{action=Index}/{id?}");
    });