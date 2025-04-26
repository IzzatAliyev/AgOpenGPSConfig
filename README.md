1. Build release 

```
dotnet build -c Release
```

2. Publish executable

Windows:
```
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```

Linux:
```
dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishSingleFile=true
```

Macos:

```
dotnet publish -c Release -r osx-x64 --self-contained true /p:PublishSingleFile=true
```


Packages added:

```
dotnet add package Avalonia.ReactiveUI
```