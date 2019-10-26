# FortBase
.Net Core startup project with already implemented patterns

## Prerequisites
1. dotnet cli 
2. .Net Core SDK 3.0
3. SQL Server (For SQL Server enabled templates)

## Installation

1. Download this package into your harddrive 
   Ex: D:/DotNetCoreTemplates
2. Open command prompt and go to the template folder that you want to install 
   Ex: If you want to setup your project with N-Layer architecture go to ~/FortBase/NLayer/FortBase (D:/DotNetCoreTemplates/FortBase/NLayer/FortBase)
3. Then run the command 

Example:
```
dotnet new -i D:\DotNetCoreTemplates\FortBase\NLayer\FortBase
```
4. This will install the FortBase N-Layer template to your dotnet new templates


## Uninstallation 

When uninstalling a template, you must uninstall it with the absolute file path. 

1. Open the command prompt 
2. Run the uninstall command 

Example:
```
dotnet new -u D:\DotNetCoreTemplates\FortBase\NLayer
```

TIP: You can use dotnet new -u command to list all the templates that you need to uninstall. 
This will show all the templates with the uninstall command.

## Template Usage

To start a project with this template use command within the folder where you want to create your project. 
Ex: If you want to start your development in D:/Developments then run following command 
   
```
dotnet new fortbase-api-nlayer -n {YOUR-PROJECT-NAME} --force
```

### For SQL Server DB Enabled Templates:

1. Go to the appsettings.json in {PROJECT-NAME}.API 
2. Check the ConnectionString and create a database in your SQL Server with the same name of the database name in the ConnectionString.

Example
```
"ConnectionString": {
    "MyCartDb": "Server=[Your-Server-Name];Database=MyCartDB;Trusted_Connection=True;"
  },
```
In the above connection string, the database name is MyCartDB. So create a new database called MyCartDB in your SQL Server instance. 
