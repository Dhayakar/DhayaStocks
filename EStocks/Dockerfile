#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["EStocks/EStocks.csproj", "EStocks/"]
RUN dotnet restore "EStocks/EStocks.csproj"
COPY . .
WORKDIR "/src/EStocks"
RUN dotnet build "EStocks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EStocks.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EStocks.dll"]