#dockerize asp.net 6.0 project

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

#CMD addgroup aspapp && adduser -S -G aspapp aspapp
#USER aspapp

WORKDIR /aspapp
COPY *.csproj .
CMD dontnet restore


COPY . .
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /aspapp/out .
ENTRYPOINT ["dotnet", "StudentManager.dll"]





#Very Very Easy Dockerize asp.net project
#1. publish project 
#2. create Dockerfile in publish project folder
#3. copy 👇

#FROM mcr.microsoft.com/dotnet/aspnet:6.0
#WORKDIR /app
#COPY . .
#ENTRYPOINT ["dotnet", "StudentManager.dll"]