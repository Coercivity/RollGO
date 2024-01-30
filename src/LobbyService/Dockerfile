FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5228

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LobbyAPI/LobbyAPI.csproj", "LobbyAPI/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "LobbyAPI/LobbyAPI.csproj"
COPY . .
WORKDIR "/src/LobbyAPI"
RUN dotnet build "LobbyAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LobbyAPI.csproj" -c Release -o /app/publish

WORKDIR /app/certs
COPY *.pem /etc/ssl/certs
CMD ["update-ca-certificates"]

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LobbyAPI.dll"]