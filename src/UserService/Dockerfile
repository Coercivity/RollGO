FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5282

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["UserAPI/UserAPI.csproj", "UserAPI/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "UserAPI/UserAPI.csproj"
COPY . .
WORKDIR "/src/UserAPI"
RUN dotnet build "UserAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserAPI.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD [ "update-ca-certificates" ]
ENTRYPOINT ["dotnet", "UserAPI.dll"]