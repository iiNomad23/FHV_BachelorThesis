# Test Case Management System

Backend code.  
Written in .NET Core using EF Core and MariaDB.

## Docker
Docker MariaDB Container  
`docker run --name mariadb-container -e MYSQL_ROOT_PASSWORD=admin -p 3306:3306 -d mariadb:latest`


## EF Core migrations

### JetBrains Rider IDE
First we need `dotnet add package Microsoft.EntityFrameworkCore.Tools` and `dotnet tool install --global dotnet-ef` to execute `dotnet ef` commands

To create a new migration for your EF Core DbContext, open the terminal in Rider and navigate to the project directory that contains your DbContext class. Then, run the following command  
`dotnet ef migrations add MigrationName`

To apply the migration and update the database schema, run the following command  
`dotnet ef database update`

### Visual Studio
Create a migration for the TestCases model  
`Add-Migration CreateTestCases`  

To apply the migration and create the table in the database, run the following command  
`Update-Database`