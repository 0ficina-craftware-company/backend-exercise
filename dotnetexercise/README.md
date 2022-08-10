# .NET 6 Test API

## System Requirements 
To run this software you need to have installed:
* .Net 6 SDK
* Docker

# How to run the software

## Run Locally
To run the API locally you will need to have SQL Server installed and running and you should edit the myDotNetTestApi/appsettings.json file to add your server's details like user, password and server address.

Run the following commands on /myDotNetTestApi directory:
* dotnet build
* dotnet run

Now the api should be running on port 8000.

## Run via Docker
The api is prepared to run on docker containers alongside with a docker instance of the SQL Server express, to do it, you just need to edit the myDotNetTestApi/appsettings.json file and add your local ip address to the connection string (unfortunately this was one of the issues i could not solve in time, to use the service name instead of the local ip address to make the api connect the docker container of the SQL server) 

Run the following commands on the root of the project:
* docker compose -f "myDotNetTestApi/docker-compose.yml" up -d --build

Run "docker ps" and you should see the containers running and their're respective ports.

If everything goes as supposed, the api should be running now alongside the sql server.

# Testing the API
if you want to test the API quickly just input in your browser the following http://localhost:5000/companies?pageNumber=1&pageSize=10 and you should get a response.

# Info about the project

## What i would improve if i had more time
- Fix the issue that it's preventing the api to connect to the docker sql server without the IP address, just using the docker service name.
- Add unit tests.
- Add more validations for the request body data in the endpoints PUT/POST/DELETE.
- Add a certificate and https endpoint.

## Resume

Since i'm new to the .net world i didn't know well where to start so i've just picked .net 6 and Entity framework because there was good documentation online and because it was recent and it seemed like a good choice to start.

If the structure of the files feels weird that's probably because i started the project on a windows computer(my desktop pc) with Visual Studio 2022 and since i went on holidays with my family i had to resort to use my laptop which runs Ubuntu and i could only use VS code.

