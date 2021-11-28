FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Admission/Admission.csproj", "Admission/"]
RUN dotnet restore "Admission/Admission.csproj"
COPY . .
WORKDIR "/src/Admission"
RUN dotnet build "Admission.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Admission.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Admission.dll"]
