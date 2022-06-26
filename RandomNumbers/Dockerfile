FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RandomNumbers/RandomNumbers.csproj", "RandomNumbers/"]
RUN dotnet restore "RandomNumbers/RandomNumbers.csproj"
COPY . .
WORKDIR "/src/RandomNumbers"
RUN dotnet build "RandomNumbers.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RandomNumbers.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RandomNumbers.dll"]
