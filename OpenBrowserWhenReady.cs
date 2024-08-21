using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TitleQuest;

internal class OpenBrowserWhenReady : BackgroundService
{
    public OpenBrowserWhenReady(IConfiguration configuration)
    {
        Url = configuration["Kestrel:EndPoints:Http:Url"] ?? throw new InvalidOperationException("Missing Kestrel:EndPoints:Http:Url in appsettings");
    }

    public string Url { get; }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Yield();

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Url,
                UseShellExecute = true
            });
        }
    }
}