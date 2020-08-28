FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["VehicleProject/VehicleProject.csproj", "VehicleProject/"]
RUN dotnet restore "VehicleProject/VehicleProject.csproj"
COPY . .
WORKDIR "/src/VehicleProject"
RUN dotnet build "VehicleProject.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VehicleProject.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VehicleProject.dll"]