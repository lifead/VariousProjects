##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["Web20200924/Web20200924.csproj", "Web20200924/"]
#RUN dotnet restore "Web20200924/Web20200924.csproj"
#COPY . .
#WORKDIR "/src/Web20200924"
#RUN dotnet build "Web20200924.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Web20200924.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Web20200924.dll"]

# ����� ��������� Docker ������ �� ������ �������� ����� ��������� ����� �����
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1	
# TCP ����, ������� ����� ������� Docker � � ���������� ����� �������������� ��� �������������
#/bin/sh -c dotnet build -c Release
# RUN ls
# RUN /bin/sh -c dotnet build -c Release
# RUN /bin/sh -c dotnet publish -c Release
EXPOSE 80										
# �����������
COPY bin/Release/netcoreapp3.1/publish/ App/	
# ������������� ������� ������� ��� ����� ��������
WORKDIR /App									
# ������������� ����� ����� / ������� ����������
ENTRYPOINT ["dotnet", "Web20200924.dll"]		