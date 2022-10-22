FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BusinessStore/BusinessStore.csproj", "BusinessStore/"]
RUN dotnet restore "BusinessStore/BusinessStore.csproj"
COPY . .
WORKDIR "/src/BusinessStore"
RUN dotnet build "BusinessStore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BusinessStore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BusinessStore.dll"]
