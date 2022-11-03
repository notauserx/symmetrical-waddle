docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

# Migrations are set up to be on a seperate project. Use 

```shell
dotnet ef migrations add InitialCreate --project ..\..\Data\Context.Migrations
```