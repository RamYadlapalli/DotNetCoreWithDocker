FROM microsoft/dotnet:latest
WORKDIR /app
COPY bin/Debug/netcoreapp1.1/publish/ /app
ENTRYPOINT dotnet DotNetCoreWithDocker.dll