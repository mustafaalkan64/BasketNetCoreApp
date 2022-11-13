#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BasketWebApp.API/BasketWebApp.API.csproj", "BasketWebApp.API/"]
RUN dotnet restore "BasketWebApp.API/BasketWebApp.API.csproj"
COPY . .
WORKDIR "/src/BasketWebApp.API"
RUN dotnet build "BasketWebApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BasketWebApp.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BasketWebApp.API.dll"]