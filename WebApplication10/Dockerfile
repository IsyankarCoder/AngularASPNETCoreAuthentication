#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 49912
EXPOSE 44304

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["JsonWebTokenWithAngularAspNetCore/JsonWebTokenWithAngularAspNetCore.csproj", "JsonWebTokenWithAngularAspNetCore/"]
RUN dotnet restore "JsonWebTokenWithAngularAspNetCore/JsonWebTokenWithAngularAspNetCore.csproj"
COPY . .
WORKDIR "/src/JsonWebTokenWithAngularAspNetCore"
RUN dotnet build "JsonWebTokenWithAngularAspNetCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JsonWebTokenWithAngularAspNetCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JsonWebTokenWithAngularAspNetCore.dll"]
