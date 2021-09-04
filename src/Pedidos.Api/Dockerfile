#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Pedidos.Api/Pedidos.Api.csproj", "Pedidos.Api/"]
RUN dotnet restore "Pedidos.Api/Pedidos.Api.csproj"
COPY . .
WORKDIR "/src/Pedidos.Api"
RUN dotnet build "Pedidos.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pedidos.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pedidos.Api.dll"]