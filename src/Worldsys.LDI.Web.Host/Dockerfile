#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Worldsys.LDI.Web.Host/Worldsys.LDI.Web.Host.csproj", "src/Worldsys.LDI.Web.Host/"]
COPY ["src/Worldsys.LDI.Web.Core/Worldsys.LDI.Web.Core.csproj", "src/Worldsys.LDI.Web.Core/"]
COPY ["src/Worldsys.LDI.Application/Worldsys.LDI.Application.csproj", "src/Worldsys.LDI.Application/"]
COPY ["src/Worldsys.LDI.Application.Shared/Worldsys.LDI.Application.Shared.csproj", "src/Worldsys.LDI.Application.Shared/"]
COPY ["src/Worldsys.LDI.Core.Shared/Worldsys.LDI.Core.Shared.csproj", "src/Worldsys.LDI.Core.Shared/"]
COPY ["src/Worldsys.LDI.Core/Worldsys.LDI.Core.csproj", "src/Worldsys.LDI.Core/"]
COPY ["src/Worldsys.LDI.EntityFrameworkCore/Worldsys.LDI.EntityFrameworkCore.csproj", "src/Worldsys.LDI.EntityFrameworkCore/"]
COPY ["src/Worldsys.LDI.GraphQL/Worldsys.LDI.GraphQL.csproj", "src/Worldsys.LDI.GraphQL/"]
RUN dotnet restore "src/Worldsys.LDI.Web.Host/Worldsys.LDI.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Worldsys.LDI.Web.Host"
RUN dotnet build "Worldsys.LDI.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Worldsys.LDI.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Worldsys.LDI.Web.Host.dll"]
