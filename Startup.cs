namespace TitleQuest;

internal class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHostedService<OpenBrowserWhenReady>();
        services.AddLogging(builder => builder.AddConsole());
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseDefaultFiles();
        app.UseStaticFiles();
    }
}