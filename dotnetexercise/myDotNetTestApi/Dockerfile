## Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS BASE
WORKDIR /app
EXPOSE 8000
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS BUILD
WORKDIR /src
COPY ["myDotNetTestApi.csproj", "./"]
RUN dotnet restore "./myDotNetTestApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "myDotNetTestApi.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "myDotNetTestApi.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:8000
ENTRYPOINT ["dotnet", "myDotNetTestApi.dll"]