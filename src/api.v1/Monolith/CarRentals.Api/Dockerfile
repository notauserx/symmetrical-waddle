#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["api.v1/Monolith/CarRentals.Api/CarRentals.Api.csproj", "api.v1/Monolith/CarRentals.Api/"]
RUN dotnet restore "api.v1/Monolith/CarRentals.Api/CarRentals.Api.csproj"
COPY . .
WORKDIR "/src/api.v1/Monolith/CarRentals.Api"
RUN dotnet build "CarRentals.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarRentals.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarRentals.Api.dll"]