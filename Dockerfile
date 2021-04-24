FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 6060

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src

COPY ["exploreMostar.WEBAPI/exploreMostar.WebAPI.csproj", "exploreMostar.WebAPI/"]
COPY . .


FROM build AS publish
RUN dotnet publish "exploreMostar.WEBAPI" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "/app/publish/exploreMostar.WebAPI.dll"]