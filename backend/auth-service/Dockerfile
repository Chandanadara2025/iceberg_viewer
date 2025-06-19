# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy only the .csproj file to leverage layer caching
COPY auth-service.csproj ./
RUN dotnet restore

# Copy rest of the source code
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 5000
ENTRYPOINT ["dotnet", "auth-service.dll"]
