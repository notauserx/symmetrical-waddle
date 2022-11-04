# CarRentals

A sample project where I develop a car rental application.


# Running the api

- For fist time users set up the docker desktop and create a docker network named carrentals-net
- In docker profile 
	- change the connectionString to carrentalsdb
	- The network argument is specified in dockerfileRunArguments field in the launchSettings file.
	- Run docker network inspect carrentals-net to verify the api and db are in the carrentals-net network.
	- If not, Run docker network connect carrentals-net CarRentals.Api to add the container to the network


# Setup up the development environment

### Setting up docker network

- Create and link the api and db containers to the carrentals-net network.

```shell
docker network create --driver bridge carrentals-net
```

### Running the mssql server

- Run the mssql server with the following command

```shell
docker run --name carrentalsdb -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=2Secure*Password2"  --network carrentals-net -p 1445:1433 -d mcr.microsoft.com/mssql/server:2019-latest
```

- After running this command, the container is available from docker desktop, where it can be started or stopped manually.
- To log in to this server, use docker ps to get the container id, then type

```shell
docker exec -it <container id> /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 2Secure*Password2
```

this will bring up the sqlcmd utility. To learn more about how to use this utility, refer to [this link](https://learn.microsoft.com/en-us/sql/ssms/scripting/sqlcmd-use-the-utility?view=sql-server-ver16).

# Migrations

- Migrations are set up in a seperate folder, when adding migrations use the --project option to specify the project.

```shell
dotnet ef migrations add <migration-name> --project ..\..\Data\Context.Migrations
```

```shell
dotnet ef database update
```

Refer to [this guide](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli) for managing ef core migrations.
