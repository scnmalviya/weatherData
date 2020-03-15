FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8001
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["./GetWeather.csproj", "./"]
RUN dotnet restore "./GetWeather.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GetWeather.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GetWeather.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GetWeather.dll"]