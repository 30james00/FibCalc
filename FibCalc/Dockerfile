# Build app
FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS publish
WORKDIR /src
COPY . .
RUN dotnet restore "FibCalc.csproj"
RUN dotnet publish "FibCalc.csproj" -c Release -o /app/publish --no-restore

# Alpine based image for the smallest image size
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FibCalc.dll"]
