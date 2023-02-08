# Dotnet Core WebRTC Video Call
## Requirments:
- dotnet 6 sdk (for build)

build:
```powershell
dotnet restore
dotnet build
```

run:
```powershell
dotnet run
```

publish:
```powershell
dotnet publish -c Release -o publish/ --self-contained
```
run after publish:
```powershell
cd publish # go to published folder
dotnet webrtc-dotnetcore.dll --urls https://0.0.0.0:3000
```
trust certificate:
```powershell
dotnet dev-certs https --trust
```

**Author:** [Ali Khadivi](https://github.com/AliKhadivi/)
