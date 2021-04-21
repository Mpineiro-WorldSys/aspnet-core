#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Worldsys.LDI.Migrator/Worldsys.LDI.Migrator.csproj", "src/Worldsys.LDI.Migrator/"]
COPY ["src/Worldsys.LDI.EntityFrameworkCore/Worldsys.LDI.EntityFrameworkCore.csproj", "src/Worldsys.LDI.EntityFrameworkCore/"]
COPY ["src/Worldsys.LDI.Core/Worldsys.LDI.Core.csproj", "src/Worldsys.LDI.Core/"]
COPY ["src/Worldsys.LDI.Core.Shared/Worldsys.LDI.Core.Shared.csproj", "src/Worldsys.LDI.Core.Shared/"]
RUN dotnet restore "src/Worldsys.LDI.Migrator/Worldsys.LDI.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Worldsys.LDI.Migrator"
RUN dotnet build "Worldsys.LDI.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Worldsys.LDI.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Worldsys.LDI.Migrator.dll"]
