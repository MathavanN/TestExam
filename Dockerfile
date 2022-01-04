FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore ./UUID/UUID.csproj
RUN dotnet restore ./UUID_Test/UUID_Test.csproj

COPY . .
WORKDIR /src/UUID/
RUN dotnet build

FROM build AS testrunner
WORKDIR /src/UUID_Test/
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

FROM build AS test
WORKDIR /src/UUID_Test/
RUN dotnet test

FROM build AS publish
WORKDIR /src/UUID/
RUN dotnet publish -c Release -o /out

FROM base AS final
WORKDIR /out
COPY --from=publish /out/ .
ENTRYPOINT ["dotnet", "UUID.dll"]
