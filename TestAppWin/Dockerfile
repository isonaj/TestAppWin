FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY TestAppWin/TestAppWin.csproj TestAppWin/
RUN dotnet restore TestAppWin/TestAppWin.csproj
COPY . .
WORKDIR /src/TestAppWin
RUN dotnet build TestAppWin.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TestAppWin.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestAppWin.dll"]
