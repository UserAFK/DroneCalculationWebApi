# Використовуйте офіційне зображення .NET Core SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Установіть git для клонування репозиторію
RUN apt-get update && \
    apt-get install -y git

WORKDIR /app

# Клонуйте ваш репозиторій GitHub з гілки dev
RUN git clone --branch dev https://github.com/UserAFK/DroneCalculationWebApi.git .

# Встановіть залежності та зібрайте ваш додаток
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Використовуйте офіційне зображення .NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "DroneCalculationWebApi.dll"]
