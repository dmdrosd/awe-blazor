FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/App/_Blazor.Starter/_Blazor.Starter.csproj", "_Blazor.Starter/"]
RUN dotnet restore "src/App/_Blazor.Starter/_Blazor.Starter.csproj"
COPY . .
WORKDIR "/src/_Blazor.Starter"
RUN dotnet build "_Blazor.Starter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "_Blazor.Starter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "_Blazor.Starter.dll"]
