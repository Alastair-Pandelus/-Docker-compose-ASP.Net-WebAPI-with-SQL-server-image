#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MyDocker/MyDocker.csproj", "MyDocker/"]
COPY ["MyDocker.Data/MyDocker.Data.csproj", "MyDocker.Data/"]
COPY ["MyDocker.Domain/MyDocker.Domain.csproj", "MyDocker.Domain/"]
RUN dotnet restore "MyDocker/MyDocker.csproj"
COPY . .
WORKDIR "/src/MyDocker"
RUN dotnet build "MyDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyDocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 5000
ENTRYPOINT ["dotnet", "MyDocker.dll"]
