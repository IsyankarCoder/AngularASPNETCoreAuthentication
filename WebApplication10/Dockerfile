#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 49912
EXPOSE 44304

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["WebApplication10/WebApplication10.csproj", "WebApplication10/"]
RUN dotnet restore "WebApplication10/WebApplication10.csproj"
COPY . .
WORKDIR "/src/WebApplication10"
RUN dotnet build "WebApplication10.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApplication10.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApplication10.dll"]