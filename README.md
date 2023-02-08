# Order Management System
-------------------------
1. Create a repo in Git. Eg: https://github.com/hasi2470/OrderManagementSystem.git
2. Create a new repository on the command line 
	echo "# OrderManagementSystem" >> README.md
	git init
	git add README.md
	git commit -m "first commit"
	git branch -M main
	git remote add origin https://github.com/hasi2470/OrderManagementSystem.git
	git push -u origin main
3.   git branch --all
    * main
    remotes/origin/main
4. git branch develop
  This will create new local branch "develop" from active branch 
5. git branch --all
  develop
* main
  remotes/origin/main
6.  git switch develop
Switched to branch 'develop'
7. git status
To check status of pending changes
 // git push --set-upstream origin develop
 8. dotnet new gitignore
The template "dotnet gitignore file" was created successfully.

 # Create the database project in Visual Studio
 1. Create new SQL Server database project: "OrderManagementSystemDb" in your folder
 2. Add new table
 CREATE TABLE [dbo].[Customer]
(
	[Cust_Id] INT NOT NULL PRIMARY KEY,
	[Name] nvarchar(50) NOT NULL,
	[Adderess] nvarchar(100),
	[Contact_num] nvarchar(13),
	[UserName] nvarchar(20) NOT NULL UNIQUE,
	[Password] nvarchar(20) NOT NULL
)
3. Save and Build the project
4. Right click on project and select publish option
5. Select target database connection(local server)
6. Give the new db name or select existing db
7. Click on publish (It'll run all scripts from the project and create the tables or stored procedure in target database)

# Creating Project in Visual Studio:
1. Create a new Project Select WebApi template
2. EF Core Db first approach:

# Install Below Nuget Packages to Project in order to use Entity framework:
	1. Install-Package Microsoft.EntityFrameworkCore.Tools
	2. Install-Package Microsoft.EntityFrameworkCore.SqlServer
	3. NuGet\Install-Package Microsoft.VisualStudio.Web.CodeGeneration -Version 6.0.11
	
# Run below command in Package Manager Console to generate DbContext and Model classes for tables:
Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB; Database=OrderManagementSystemDb; Trusted_Connection=True;trustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -Context "OrderManagementDbContext" -OutputDir "Models" -ContextDir "Dal" -DataAnnotations -t customer -force

# MSSQLLocalDB Connection String :
Add the below connection string to appsetting.development.json:
 "ConnectionStrings": {
    "ConnectionString": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OrderManagementSystemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  }
 
# Add below code to program.cs for DI of dbContext to use connection string dynamically from appsettings
builder.Services.AddDbContext<OrderManagementDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});


