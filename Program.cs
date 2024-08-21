using Microsoft.AspNetCore;
using TitleQuest;

// manual bootstraping to configure some settings outside Development environment:
// port number, Urls, browser startup ...

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var builder = WebHost.CreateDefaultBuilder(args);
builder.UseConfiguration(configuration);
builder.UseKestrel();
builder.UseStartup<Startup>();

var app = builder.Build();

app.Run();
