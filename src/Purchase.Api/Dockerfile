FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5121

ENV ASPNETCORE_URLS=http://+:5121

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/Purchase.Api/Purchase.Api.csproj", "src/Purchase.Api/"]
RUN dotnet restore "src/Purchase.Api/Purchase.Api.csproj"
COPY . .
WORKDIR "/src/src/Purchase.Api"
RUN dotnet build "Purchase.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Purchase.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Purchase.Api.dll"]
