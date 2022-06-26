FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Final/Final.csproj", "Final/"]
RUN dotnet restore "Final/Final.csproj"
COPY . .
WORKDIR "/src/Final"
RUN dotnet build "Final.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Final.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Final.dll"]
