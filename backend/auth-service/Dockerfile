# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy project files and restore dependencies
COPY ["auth-service/*.csproj", "./"]
RUN dotnet restore

# Copy the entire source and build the application
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Create a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy built artifacts from the previous stage
COPY --from=build /app/publish .

# Expose the application port
EXPOSE 5000

# Define the entrypoint
ENTRYPOINT ["dotnet", "AuthService.dll"]
