FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Ensure correct path for copying .csproj
COPY ["backend/auth-service/auth-service.csproj", "./"]
RUN dotnet restore

# Copy source files based on folder structure
COPY backend/auth-service/. .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Create runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy built application from previous stage
COPY --from=build /app/publish .

EXPOSE 5000
ENTRYPOINT ["dotnet", "AuthService.dll"]
