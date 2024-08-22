# dotnet-open-browser-when-ready

POC: automatically open the homepage in default browser,
as soon as application is ready to process requests.

Tries to reproduce the behaviour of `launchBrowser` property, from _launchSettings.json_,
but with code only and in _Release_ configuration.

Windows only – but easily adaptable.

## Run locally

```
dotnet run
```

## Building a release version

Single-file, trimmed, self-contained:

```
dotnet publish -c Release -p:DebugType=None -p:DebugSymbols=false
```
