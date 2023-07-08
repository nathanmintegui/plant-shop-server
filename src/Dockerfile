FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["./Application/PlantShop.Application/PlantShop.Application.csproj", "src/Application/PlantShop.Application/"]
COPY ["./Domain/PlantShop.Domain/PlantShop.Domain.csproj", "src/Domain/PlantShop.Domain/"]
COPY ["./Infrastructure/PlantShop.Infrastructure/PlantShop.Infrastructure.csproj", "src/Infrastructure/PlantShop.Infrastructure/"]
COPY ["./Presentation/PlantShop.WebAPI/PlantShop.WebAPI.csproj", "src/Presentation/PlantShop.WebAPI/"]

RUN dotnet restore "src/Presentation/PlantShop.WebAPI/PlantShop.WebAPI.csproj"

COPY . .

WORKDIR "/src/Presentation/PlantShop.WebAPI/"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS runtime 
WORKDIR /app

COPY --from=publish /app/publish .
RUN ls -l
ENTRYPOINT ["dotnet", "PlantShop.WebAPI.dll"]