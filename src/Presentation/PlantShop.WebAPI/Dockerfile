FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Presentation/PlantShop.WebAPI/PlantShop.WebAPI.csproj", "src/Presentation/PlantShop.WebAPI/"]
RUN dotnet restore "src/Presentation/PlantShop.WebAPI/PlantShop.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Presentation/PlantShop.WebAPI"
RUN dotnet build "PlantShop.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlantShop.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlantShop.WebAPI.dll"]
