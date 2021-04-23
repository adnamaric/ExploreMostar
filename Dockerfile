FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5050

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src

COPY ["exploreMostar.WebApi/exploreMostar.WebAPI.csproj", "exploreMostar.WebAPI/"]
COPY ["exploreMostar.Model/exploreMostar.Model.csproj", "exploreMostar.Model/"]
RUN dotnet restore "exploreMostar.WebAPI"
COPY . .



FROM build AS publish
RUN dotnet publish "exploreMostar.WebApi" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "/app/publish/exploreMostar.WebAPI.dll"]